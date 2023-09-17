using FoodPlannerE2E.ApiManager.Enums;
using FoodPlannerE2E.ApiManager.Models.Category;
using FoodPlannerE2E.Pages.PageObjectModels.Product;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;

namespace FoodPlannerE2E.Tests.Fixtures.Product
{
    public class CreateProductFixture : BaseTestFixture
    {
        protected CategoryResponse Category { get; private set; }
        protected EntityApiService EntityApiService { get; private set; }
        protected CreateProductPageObject CreateProductPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCard { get; private set; }

        [OneTimeSetUp]
        protected void Setup()
        {
            CreateProductPage = new(Driver);
            ResponseStatusCard = new(Driver);

            CreateProductPage.NavigateTo();
        }

        protected override async Task PrepareTestDataAsync()
        {
            EntityApiService = new EntityApiService(HttpClientFactory.GetHttpClient(EntityType.Category));
            var categoryName = ValueGenerator.GenerateString(10);

            Category = await EntityApiService.CreateAsync<CategoryRequest, CategoryResponse>(new CategoryRequest { Name = categoryName });
        }
    }
}
