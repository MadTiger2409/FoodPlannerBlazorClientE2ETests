using FoodPlannerE2E.Core.Configs.PageLocators.Shared;
using OpenQA.Selenium;

namespace FoodPlannerE2E.Pages.PageObjectModels.Shared
{
    public class ResponseStatusPageObject : BasePageObject<ResponseStatusPageLocators>
    {
        public string TitleHeaderText { get => TitleHeader.Text; }
        protected IWebElement BodyDiv { get => _driver.FindElement(By.XPath(Locators.BodyDiv)); }
        protected IWebElement TitleHeader { get => _driver.FindElement(By.XPath(Locators.TitleHeader)); }
        protected IWebElement CloseButton { get => _driver.FindElement(By.XPath(Locators.CloseButton)); }

        public ResponseStatusPageObject(IWebDriver driver) : base(driver) { }
    }
}
