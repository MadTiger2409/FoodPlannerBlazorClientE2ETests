using FoodPlannerE2E.ApiManager.Enums;
using FoodPlannerE2E.ApiManager.Models.Unit;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;

namespace FoodPlannerE2E.Tests.Fixtures.Unit
{
    public class DeleteUnitFixture : BaseTestFixture
    {
        protected UnitResponse UnitToDelete { get; private set; }
        protected EntityApiService EntityApiService { get; private set; }
        protected EditUnitPageObject EditUnitPage { get; private set; }
        protected UnitsListPageObject UnitsListPage { get; private set; }
        protected DeleteEntityModalPageObject DeleteEntityModal { get; private set; }

        [OneTimeSetUp]
        protected void Setup()
        {
            EditUnitPage = new(Driver);
            UnitsListPage = new(Driver);
            DeleteEntityModal = new(Driver);

            UnitsListPage.NavigateTo();
        }

        protected override async Task PrepareTestDataAsync()
        {
            EntityApiService = new EntityApiService(HttpClientFactory.GetHttpClient(EntityType.Unit));
            var unitName = ValueGenerator.GenerateString(10);

            UnitToDelete = await EntityApiService.CreateAsync<UnitRequest, UnitResponse>(new UnitRequest { Name = unitName });
        }
    }
}
