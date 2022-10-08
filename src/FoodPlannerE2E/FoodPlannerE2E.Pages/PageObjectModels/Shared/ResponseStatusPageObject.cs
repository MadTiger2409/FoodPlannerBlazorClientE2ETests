using FoodPlannerE2E.Core.Configs.PageLocators.Shared;
using OpenQA.Selenium;

namespace FoodPlannerE2E.Pages.PageObjectModels.Shared
{
    public class ResponseStatusPageObject : BasePageObject
    {
        public string TitleHeaderText { get => TitleHeader.Text; }
        protected IWebElement BodyDiv { get => _driver.FindElement(By.XPath(_locators.BodyDiv)); }
        protected IWebElement TitleHeader { get => _driver.FindElement(By.XPath(_locators.TitleHeader)); }
        protected IWebElement CloseButton { get => _driver.FindElement(By.XPath(_locators.CloseButton)); }

        private readonly ResponseStatusPageLocators _locators;

        public ResponseStatusPageObject(IWebDriver driver) : base(driver) => _locators = ConfigReader.GetJsonAsObject<ResponseStatusPageLocators>();
    }
}
