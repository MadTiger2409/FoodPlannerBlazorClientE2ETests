using FoodPlannerE2E.ApiManager.Enums;
using FoodPlannerE2E.Tests.Fixtures.Category;
using FoodPlannerE2E.ApiManager.Models.Category;

namespace FoodPlannerE2E.Tests.Tests.Category
{
    [TestFixture]
    [Category("Category")]
    public class SearchForCategoryPositiveTest : SearchForCategoryFixture
    {
        protected CategoryResponse CategoryToSearchFor { get; private set; }
        protected EntityApiService EntityApiService { get; private set; }

        [Test]
        public void Should_Find_Category_When_Entity_Exists()
        {
            CategoriesListPageObject.SearchForCategory(CategoryToSearchFor.Name);

            CategoriesListPageObject.ContainsCategoryWithGivenName(CategoryToSearchFor.Name).Should().BeTrue();
        }

        protected override async Task PrepareTestDataAsync()
        {
            await base.PrepareTestDataAsync();

            EntityApiService = new EntityApiService(HttpClientFactory.GetHttpClient(EntityType.Category));
            var categoryName = ValueGenerator.GenerateString(10);

            CategoryToSearchFor = await EntityApiService.CreateAsync<CategoryRequest, CategoryResponse>(new CategoryRequest { Name = categoryName });
        }
    }
}
