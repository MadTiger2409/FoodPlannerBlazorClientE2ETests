using FoodPlannerE2E.Core.Configs.PageLocators.Unit;

namespace FoodPlannerE2E.Pages.PageObjectModels.Unit
{
    public class CreateUnitPageObject : BasePageObject<CreateUnitPageLocators>
    {
        protected IWebElement NameTextBox { get => _driver.FindElement(By.XPath(Locators.NameTextInput)); }
        protected IList<IWebElement> NameErrorMessages { get => _driver.FindElements(By.XPath(Locators.NameErrorMessage)); }
        protected IWebElement SendButton { get => _driver.FindElement(By.XPath(Locators.SendButton)); }

        public CreateUnitPageObject(IWebDriver driver) : base(driver) { }

        public void InsertName(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
        }

        public bool HasErrorMessageWithGivenText(string message) => NameErrorMessages.Any(x => x.Text.Trim().ToLowerInvariant() == message.ToLowerInvariant());
        public void SendForm() => SendButton.Click();
        public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/units/new");
    }
}
