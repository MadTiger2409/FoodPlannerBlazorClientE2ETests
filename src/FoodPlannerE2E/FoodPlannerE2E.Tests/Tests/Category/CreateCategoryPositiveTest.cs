using FoodPlannerE2E.Pages.PageObjectModels.Category;
using FoodPlannerE2E.Pages.TextsAndMessages.Shared;
using FoodPlannerE2E.Tests.Fixtures.Category;

namespace FoodPlannerE2E.Tests.Tests.Category
{
    [TestFixture]
    [Category("Category")]
    public class CreateCategoryPositiveTest : CreateCategoryFixture
    {
        private string _newCategoryName;
        private string _actualTitleHeaderText;

        private CategoriesListPageObject _categoriesListPageObject;

        [Test]
        public void Should_Create_Category_When_Name_Is_Correct()
        {
            CreateCategoryPage.InsertName(_newCategoryName);
            CreateCategoryPage.SendForm();

            _actualTitleHeaderText = ResponseStatusCard.TitleText;

            _categoriesListPageObject.NavigateTo();

            _actualTitleHeaderText.Should().Be(ResponseStatusCardPageMessages.Ui.Title.Success);
            _categoriesListPageObject.ContainsUnitWithGivenName(_newCategoryName).Should().BeTrue();
        }

        [OneTimeSetUp]
        protected void TestSetup() => _categoriesListPageObject = new(Driver);

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _newCategoryName = ValueGenerator.GenerateString(10);
        }
    }
}
