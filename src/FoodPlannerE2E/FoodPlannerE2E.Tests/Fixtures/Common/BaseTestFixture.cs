using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Fixtures.Common
{
    public class BaseTestFixture : DriverFixture
    {
        [OneTimeSetUp]
        protected override async Task Setup()
        {
            await base.Setup();
            await PrepareTestData();
        }

        protected virtual async Task PrepareTestData() { }
    }
}
