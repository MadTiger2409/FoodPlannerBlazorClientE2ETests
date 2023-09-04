using FoodPlannerE2E.Core.Configs.PageLocators.Product;
using FoodPlannerE2E.Pages.Controls;

namespace FoodPlannerE2E.Pages.PageObjectModels.Product
{
    public class CreateProductPageObject : BasePageObject<CreateProductPageLocators>
    {
        public BlazoredTypeahead CategoryTypeahead { get; private set; }

        protected IWebElement NameTextBox => _driver.FindElement(By.XPath(Locators.NameTextInput));
        protected IList<IWebElement> NameErrorMessages => _driver.FindElements(By.XPath(Locators.NameErrorMessage));
        protected IList<IWebElement> CategoryErrorMessages => _driver.FindElements(By.XPath(Locators.CategoryErrorMessage));
        protected IWebElement SendButton => _driver.FindElement(By.XPath(Locators.SendButton));

        public CreateProductPageObject(IWebDriver driver) : base(driver) => CategoryTypeahead = new(_driver, Locators.CategoryTypeahead);

        public void InsertName(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
        }

        public bool HasNameErrorMessageWithGivenText(string message) => NameErrorMessages.Any(x => x.Text.Trim().ToLowerInvariant() == message.ToLowerInvariant());
        public bool HasCategoryErrorMessageWithGivenText(string message) => CategoryErrorMessages.Any(x => x.Text.Trim().ToLowerInvariant() == message.ToLowerInvariant());
        public void SendForm() => SendButton.Click();
        public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/products/new");
    }
}
