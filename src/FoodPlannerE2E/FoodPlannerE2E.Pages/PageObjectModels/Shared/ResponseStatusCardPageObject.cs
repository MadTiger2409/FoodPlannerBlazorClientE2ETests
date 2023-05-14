using FoodPlannerE2E.Core.Configs.PageLocators.Shared;
using OpenQA.Selenium;

namespace FoodPlannerE2E.Pages.PageObjectModels.Shared
{
    public class ResponseStatusCardPageObject : BasePageObject<ResponseStatusCardLocators>
    {
        public string TitleText { get => Title.Text; }
        protected IWebElement Body { get => _driver.FindElement(By.XPath(Locators.Body)); }
        protected IWebElement Title { get => _driver.FindElement(By.XPath(Locators.Title)); }
        protected IWebElement CloseButton { get => _driver.FindElement(By.XPath(Locators.CloseButton)); }

        public ResponseStatusCardPageObject(IWebDriver driver) : base(driver) { }
    }
}
