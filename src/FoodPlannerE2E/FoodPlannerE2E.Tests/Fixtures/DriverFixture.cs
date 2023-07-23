using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FoodPlannerE2E.Tests.Fixtures
{
    public class DriverFixture
    {
        public IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        protected void DriverSetup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        protected void DriverCleanup() => Driver.Close();
    }
}
