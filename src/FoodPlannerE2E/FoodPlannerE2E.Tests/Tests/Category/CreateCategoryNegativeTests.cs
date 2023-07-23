using FoodPlannerE2E.Tests.Fixtures.Category;

namespace FoodPlannerE2E.Tests.Tests.Category
{
    [TestFixture]
    [Category("Category")]
    public class CreateCategoryNegativeTests : CreateCategoryFixture
    {
        private string _emptyName;
        private string _tooShortName;
        private string _tooLongName;

        [Test]
        public void Should_Not_Create_Category_When_Name_Is_Empty()
        {
            CreateCategoryPage.InsertName(_emptyName);
            CreateCategoryPage.SendForm();

            CreateCategoryPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanNotBeEmpty).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Category_When_Name_Is_Too_Short()
        {
            CreateCategoryPage.InsertName(_tooShortName);
            CreateCategoryPage.SendForm();

            CreateCategoryPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.MustBeOfMinimumLength).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Category_When_Name_Is_Too_Long()
        {
            CreateCategoryPage.InsertName(_tooLongName);
            CreateCategoryPage.SendForm();

            CreateCategoryPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanBeOfMaximumLength).Should().BeTrue();
        }

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _emptyName = string.Empty;
            _tooShortName = ValueGenerator.GenerateString(1);
            _tooLongName = ValueGenerator.GenerateString(102);
        }
    }
}
