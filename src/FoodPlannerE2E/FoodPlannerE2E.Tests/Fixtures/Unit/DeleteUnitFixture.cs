using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Fixtures.Unit
{
    public class DeleteUnitFixture : DriverFixture
    {
        protected EditUnitPageObject EditUnitPage { get; private set; }
        protected DeleteEntityModalPageObject DeleteEntityModal { get; private set; }

        [OneTimeSetUp]
        protected override void Setup()
        {
            base.Setup();
            EditUnitPage = new(Driver);
            DeleteEntityModal = new(Driver);
        }
    }
}
