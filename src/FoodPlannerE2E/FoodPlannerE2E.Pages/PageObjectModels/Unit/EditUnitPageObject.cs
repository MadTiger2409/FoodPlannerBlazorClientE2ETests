using FoodPlannerE2E.Core.Configs.PageLocators.Unit;
using OpenQA.Selenium.Interactions;

namespace FoodPlannerE2E.Pages.PageObjectModels.Unit
{
    public class EditUnitPageObject : BasePageObject<EditUnitPageLocators>
    {
        protected IWebElement NameTextBox => _driver.FindElement(By.XPath(Locators.NameTextInput));
        protected IWebElement NameErrorMessage => _driver.FindElement(By.XPath(Locators.NameErrorMessage));
        protected IWebElement SendButton => _driver.FindElement(By.XPath(Locators.SendButton));
        protected IWebElement EditButton => _driver.FindElement(By.XPath(Locators.EditButton));
        protected IWebElement DeleteButton => _driver.FindElement(By.XPath(Locators.DeleteButton));

        public EditUnitPageObject(IWebDriver driver) : base(driver) { }

        public void InsertName(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
        }

        public void SendForm() => SendButton.Click();
        public void SendForm(int pauseInSeconds) => new Actions(_driver).MoveToElement(SendButton).Pause(TimeSpan.FromSeconds(pauseInSeconds)).SendKeys(Keys.Enter).Perform();
        public void ChangeFormEditability() => EditButton.Click();
        public void TriggerDeleteModal() => DeleteButton.Click();
        public void NavigateTo(uint id) => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/units/{id}");
        public bool IsFormEditable() => _driver.FindElement(By.TagName("fieldset")).Enabled;
    }
}
