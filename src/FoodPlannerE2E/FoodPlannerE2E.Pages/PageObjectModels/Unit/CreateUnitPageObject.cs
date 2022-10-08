using FoodPlannerE2E.Core.Configs.PageLocators.Unit;
using OpenQA.Selenium;

namespace FoodPlannerE2E.Pages.PageObjectModels.Unit
{
    public class CreateUnitPageObject : BasePageObject
    {
        protected IWebElement NameTextBox { get => _driver.FindElement(By.XPath(_locators.NameTextBox)); }
        protected IWebElement NameErrorMessage { get => _driver.FindElement(By.XPath(_locators.NameErrorMessage)); }
        protected IWebElement SendButton { get => _driver.FindElement(By.XPath(_locators.SendButton)); }

        private readonly CreateUnitPageLocators _locators;

        public CreateUnitPageObject(IWebDriver driver) : base(driver) => _locators = ConfigReader.GetJsonAsObject<CreateUnitPageLocators>();

        public void InsertName(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
        }

        public void SendForm() => SendButton.Click();

        public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/units/new");
    }
}
