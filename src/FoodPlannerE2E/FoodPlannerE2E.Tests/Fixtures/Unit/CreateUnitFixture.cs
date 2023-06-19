using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Tests.Fixtures.Common;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Fixtures.Unit
{
    public class CreateUnitFixture : BaseTestFixture
    {
        protected CreateUnitPageObject CreateUnitPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCard { get; private set; }

        [OneTimeSetUp]
        protected override async Task Setup()
        {
            await base.Setup();
            CreateUnitPage = new(Driver);
            ResponseStatusCard = new(Driver);

            CreateUnitPage.NavigateTo();
        }
    }
}
