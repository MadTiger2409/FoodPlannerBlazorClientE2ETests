using FoodPlannerE2E.ApiManager.Enums;
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

        private EntityApiService _entityApiService;
        private CategoriesListPageObject _categoriesListPageObject;

        [Test]
        public void Should_Create_Category_When_Name_Is_Correct()
        {
            CreateCategoryPage.InsertName(_newCategoryName);
            CreateCategoryPage.SendForm();

            _actualTitleHeaderText = ResponseStatusCard.TitleText;

            _categoriesListPageObject.NavigateTo();

            _actualTitleHeaderText.Should().Be(ResponseStatusCardPageMessages.Ui.Title.Success);
            _categoriesListPageObject.ContainsCategoryWithGivenName(_newCategoryName).Should().BeTrue();
        }

        [OneTimeSetUp]
        public void TestSetup() => _categoriesListPageObject = new(Driver);


        [OneTimeTearDown]
        public void TestCleanup()
        {
            //TODO Add steps to delete newly added category
        }


        protected override async Task PrepareTestDataAsync()
        {
            base.PrepareTestData();
            _newCategoryName = ValueGenerator.GenerateString(10);

            _entityApiService = new EntityApiService(HttpClientFactory.GetHttpClient(EntityType.Category));
        }
    }
}
