using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FoodPlannerE2E.Tests.Fixtures
{
	public class DriverFixture : IDisposable
	{
		public IWebDriver Driver { get; set; }

		public DriverFixture()
		{
			Driver = new ChromeDriver();
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
			Driver.Manage().Window.Maximize();
		}

		public void Dispose()
		{
			Driver.Close();
		}
	}
}
