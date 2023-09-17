using FoodPlannerE2E.Core.Configs.PageLocators.Product;
using FoodPlannerE2E.Pages.Extensions;

namespace FoodPlannerE2E.Pages.PageObjectModels.Product
{
    public class ProductsListPageObject : BasePageObject<ProductsListPageLocators>
    {
        protected IWebElement NameTextBox => _driver.FindElement(By.XPath(Locators.NameTextInput));
        protected IWebElement SendButton => _driver.FindElement(By.XPath(Locators.SendButton));
        protected IList<IWebElement> Products => _driver.FindElements(By.XPath(Locators.Products));
        protected IWebElement NoDataError => _driver.FindElement(By.XPath(Locators.NoDataErrorMessage));

        public ProductsListPageObject(IWebDriver driver) : base(driver) { }

        public void InsertName(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
        }

        public void SearchForCategory(string name)
        {
            NameTextBox.Clear();
            NameTextBox.SendKeys(name);
            SendButton.Click();
        }

        public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/products");
        public void SendForm() => SendButton.Click();
        public bool ContainsProductWithGivenName(string name) => Products.Any(x => x.Text.Trim() == name.ToLowerInvariant());
        public bool HasNoDataError() => _driver.DoesPageHaveExactlyOneElement(By.XPath(Locators.NoDataErrorMessage));
        public bool HasNoDataErrorWithGivenText(string text) => NoDataError.Text == text;
        public bool HasNoDataErrorDisplayed() => NoDataError.Displayed;
    }
}