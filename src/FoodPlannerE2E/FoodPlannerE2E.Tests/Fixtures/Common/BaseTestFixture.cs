﻿namespace FoodPlannerE2E.Tests.Fixtures.Common
{
    public class BaseTestFixture : DriverFixture
    {
        [OneTimeSetUp]
        protected async Task BaseTestSetup()
        {
            await PrepareTestDataAsync();
            PrepareTestData();
        }

        protected virtual async Task PrepareTestDataAsync() { }

        protected virtual void PrepareTestData() { }
    }
}
