using FoodPlannerE2E.Core.Configs.PageLocators.Unit;

namespace FoodPlannerE2E.Pages.PageObjectModels.Unit
{
    public class EditUnitPageObject : BasePageObject<EditUnitPageLocators>
    {
        protected IWebElement NameTextBox { get => _driver.FindElement(By.XPath(Locators.NameTextInput)); }
        protected IWebElement NameErrorMessage { get => _driver.FindElement(By.XPath(Locators.NameErrorMessage)); }
        protected IWebElement SendButton { get => _driver.FindElement(By.XPath(Locators.SendButton)); }
        protected IWebElement EditButton { get => _driver.FindElement(By.XPath(Locators.EditButton)); }
        protected IWebElement DeleteButton { get => _driver.FindElement(By.XPath(Locators.DeleteButton)); }

        public EditUnitPageObject(IWebDriver driver) : base(driver) { }

        public void InsertName(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
        }

        public void SendForm() => SendButton.Click();
        public void ChangeFormEditability() => EditButton.Click();
        public void TriggerDeleteModal() => DeleteButton.Click();
        public void NavigateTo(uint id) => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/units/{id}");
        public bool IsFormEditable() => _driver.FindElement(By.TagName("fieldset")).Enabled;
    }
}
