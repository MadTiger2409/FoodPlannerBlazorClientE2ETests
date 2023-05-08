﻿using FoodPlannerE2E.Core.Configs.PageLocators.Unit;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace FoodPlannerE2E.Pages.PageObjectModels.Unit
{
	public class UnitsListPageObject : BasePageObject<UnitsListPageLocators>
	{
		private IList<IWebElement> Units { get => _driver.FindElements(By.XPath(Locators.Units)); }

		public UnitsListPageObject(IWebDriver driver) : base(driver) { }

		public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/units");
		public bool ContainsUnitWithGivenName(string name) => Units.Any(x => x.FindElement(By.TagName("a")).Text.Trim() == name);
	}
}
