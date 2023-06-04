using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FoodPlannerE2E.Tests.Fixtures
{
    public class DriverFixture
	{
		public IWebDriver Driver { get; private set; }

		[OneTimeSetUp]
		protected virtual void Setup()
		{
			Driver = new ChromeDriver();
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
			Driver.Manage().Window.Maximize();
		}

		[OneTimeTearDown]
		protected virtual void Finalize() => Driver.Close();
	}
}
