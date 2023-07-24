﻿using FoodPlannerE2E.Core.Configs.PageLocators.Shared;

namespace FoodPlannerE2E.Pages.PageObjectModels.Shared
{
    public class ResponseStatusCardPageObject : BasePageObject<ResponseStatusCardLocators>
    {
        public string TitleText => Title.Text;
        protected IWebElement Body => _driver.FindElement(By.XPath(Locators.Body));
        protected IWebElement Title => _driver.FindElement(By.XPath(Locators.Title));
        protected IWebElement CloseButton => _driver.FindElement(By.XPath(Locators.CloseButton));
        protected IWebElement SuccessMessage => _driver.FindElement(By.XPath(Locators.SuccessMessage));

        public ResponseStatusCardPageObject(IWebDriver driver) : base(driver) { }


    }
}
