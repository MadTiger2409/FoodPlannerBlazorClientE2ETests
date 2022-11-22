using FoodPlannerE2E.Core.Configs.PageLocators.Unit;
using OpenQA.Selenium;

namespace FoodPlannerE2E.Pages.PageObjectModels.Unit
{
    public class EditUnitPageObject : BasePageObject
    {
        protected IWebElement NameTextBox { get => _driver.FindElement(By.XPath(_locators.NameTextInput)); }
        protected IWebElement NameErrorMessage { get => _driver.FindElement(By.XPath(_locators.NameErrorMessage)); }
        protected IWebElement SendButton { get => _driver.FindElement(By.XPath(_locators.SendButton)); }
        protected IWebElement EditButton { get => _driver.FindElement(By.XPath(_locators.EditButton)); }

        private readonly EditUnitPageLocators _locators;

        public EditUnitPageObject(IWebDriver driver) : base(driver) => _locators = ConfigReader.GetJsonAsObject<EditUnitPageLocators>();

        public void InsertName(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
        }

        public void SendForm() => SendButton.Click();
        public void ChangeFormEditability() => EditButton.Click();
        public void NavigateTo(uint id) => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/units/{id}");
        public bool IsFormEditable() => _driver.FindElement(By.TagName("fieldset")).Enabled;
    }
}
