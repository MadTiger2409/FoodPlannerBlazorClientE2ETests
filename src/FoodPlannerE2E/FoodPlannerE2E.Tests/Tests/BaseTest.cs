using FoodPlannerE2E.Tests.Fixtures;
using OpenQA.Selenium;
using Xunit;

namespace FoodPlannerE2E.Tests.Tests
{
    public class BaseTest : IClassFixture<DriverFixture>
    {
        public IWebDriver Driver { get; set; }

        public BaseTest(DriverFixture driverFixture)
        {
            Driver = driverFixture.Driver;
        }
    }
}
