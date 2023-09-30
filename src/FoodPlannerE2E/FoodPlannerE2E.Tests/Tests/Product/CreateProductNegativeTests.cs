using FoodPlannerE2E.Tests.Fixtures.Product;

namespace FoodPlannerE2E.Tests.Tests.Product
{
    [TestFixture]
    [Category("Product")]
    public class CreateProductNegativeTests : CreateProductFixture
    {
        private string _emptyName;
        private string _whiteSpaces;
        private string _tooShortName;
        private string _tooLongName;

        [Test]
        public void Should_Not_Create_Product_When_Name_Is_Empty()
        {
            CreateProductPage.CategoryTypeahead.Expand();
            CreateProductPage.CategoryTypeahead.SelectByName(Category.Name);

            CreateProductPage.InsertName(_emptyName);

            CreateProductPage.SendForm();

            CreateProductPage.HasNameErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanNotBeEmpty).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Product_When_Name_Consists_Only_If_WhiteSpaces()
        {
            CreateProductPage.CategoryTypeahead.Expand();
            CreateProductPage.CategoryTypeahead.SelectByName(Category.Name);

            CreateProductPage.InsertName(_whiteSpaces);

            CreateProductPage.SendForm();

            CreateProductPage.HasNameErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanNotBeEmpty).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Product_When_Name_Is_Too_Short()
        {

        }

        [Test]
        public void Should_Not_Create_Product_When_Name_Is_Too_Long()
        {

        }

        [Test]
        public void Should_Not_Create_Product_When_Category_Is_Not_Selected()
        {

        }

        [SetUp]
        public void EachTestSetup() => Driver.Navigate().Refresh();

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _emptyName = string.Empty;
            _whiteSpaces = ValueGenerator.Repeat(" ", 10);
            _tooShortName = ValueGenerator.GenerateString(1);
            _tooLongName = ValueGenerator.GenerateString(102);
        }
    }
}
