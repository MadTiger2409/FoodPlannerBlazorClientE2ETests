using FoodPlannerE2E.Pages.PageObjectModels.Product;
using FoodPlannerE2E.Pages.TextsAndMessages.Shared;
using FoodPlannerE2E.Tests.Fixtures.Product;

namespace FoodPlannerE2E.Tests.Tests.Product
{
    [TestFixture]
    [Category("Product")]
    public class CreateProductPositiveTest : CreateProductFixture
    {
        private string _newProductName;
        private string _actualTitleHeaderText;

        private ProductsListPageObject _productsListPageObject;

        [Test]
        public void Should_Create_ProductWhen_Category_Exists_And_Name_Is_Correct()
        {
            CreateProductPage.InsertName(_newProductName);

            CreateProductPage.CategoryTypeahead.Search(Category.Name);
            CreateProductPage.CategoryTypeahead.SelectByIndex(0);

            CreateProductPage.SendForm();

            _actualTitleHeaderText = ResponseStatusCard.TitleText;

            _productsListPageObject.NavigateTo();

            _actualTitleHeaderText.Should().Be(ResponseStatusCardPageMessages.Ui.Title.Success);
            _productsListPageObject.ContainsProductWithGivenName(_newProductName).Should().BeTrue();
        }

        [OneTimeSetUp]
        protected void TestSetup() => _productsListPageObject = new(Driver);

        //TODO Add teardown to delete newly added product

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _newProductName = ValueGenerator.GenerateString(10);
        }
    }
}
