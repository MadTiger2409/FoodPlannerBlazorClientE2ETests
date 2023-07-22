namespace FoodPlannerE2E.Tests.Fixtures.Common
{
    public class BaseTestFixture : DriverFixture
    {
        [OneTimeSetUp]
        protected async Task BaseTestSetUp()
        {
            await PrepareTestDataAsync();
            PrepareTestData();
        }

        protected virtual async Task PrepareTestDataAsync() { }

        protected virtual void PrepareTestData() { }
    }
}
