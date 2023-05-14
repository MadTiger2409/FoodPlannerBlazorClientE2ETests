using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Fixtures.Unit
{
    public class CreateUnitFixture : DriverFixture
    {
        protected CreateUnitPageObject CreateUnitPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCard { get; private set; }

        [OneTimeSetUp]
        protected override void Setup()
        {
            base.Setup();
            CreateUnitPage = new(Driver);
            ResponseStatusCard = new(Driver);

            CreateUnitPage.NavigateTo();
        }
    }
}
