using FoodPlannerE2E.ApiManager.Enums;
using FoodPlannerE2E.ApiManager.Models.Unit;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Tests.Fixtures.Common;

namespace FoodPlannerE2E.Tests.Fixtures.Unit
{
    public class EditUnitFixture : BaseTestFixture
    {
        protected UnitResponse UnitToEdit { get; private set; }
        protected EntityApiService EntityApiService { get; private set; }
        protected EditUnitPageObject EditUnitPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCardPage { get; private set; }

        [OneTimeSetUp]
        public void Setup()
        {
            EditUnitPage = new(Driver);
            ResponseStatusCardPage = new(Driver);

            EditUnitPage.NavigateTo(UnitToEdit.Id);
        }

        [OneTimeTearDown]
        public async Task Cleanup() => await EntityApiService.DeleteAsync(UnitToEdit.Id);

        protected override async Task PrepareTestDataAsync()
        {
            EntityApiService = new EntityApiService(HttpClientFactory.GetHttpClient(EntityType.Unit));
            var unitName = ValueGenerator.GenerateString(10);

            UnitToEdit = await EntityApiService.CreateAsync<UnitRequest, UnitResponse>(new UnitRequest { Name = unitName });
        }
    }
}
