using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Fixtures.Common
{
    public class BaseTestFixture : DriverFixture
    {
        [OneTimeSetUp]
        protected virtual async Task BaseTestSetup()
        {
            await PrepareTestData();
        }

        protected virtual async Task PrepareTestData() { }
    }
}
