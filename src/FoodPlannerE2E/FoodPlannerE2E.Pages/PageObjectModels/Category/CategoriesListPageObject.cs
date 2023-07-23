using FoodPlannerE2E.Core.Configs.PageLocators.Category;
using FoodPlannerE2E.Pages.Extensions;

namespace FoodPlannerE2E.Pages.PageObjectModels.Category
{
    public class CategoriesListPageObject : BasePageObject<CategoriesListPageLocators>
    {
        protected IWebElement NameTextBox => _driver.FindElement(By.XPath(Locators.NameTextInput));
        protected IWebElement SendButton => _driver.FindElement(By.XPath(Locators.SendButton));
        protected IList<IWebElement> Categories => _driver.FindElements(By.XPath(Locators.Categories));
        protected IWebElement NoDataError => _driver.FindElement(By.XPath(Locators.NoDataErrorMessage));

        public CategoriesListPageObject(IWebDriver driver) : base(driver) { }

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

        public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/categories");
        public void SendForm() => SendButton.Click();
        public bool ContainsUnitWithGivenName(string name) => Categories.Any(x => x.Text.Trim() == name.ToLowerInvariant());
        public bool HasNoDataError() => _driver.DoesPageHaveExactlyOneElement(By.XPath(Locators.NoDataErrorMessage));
        public bool HasNoDataErrorWithGivenText(string text) => NoDataError.Text == text;
        public bool HasNoDataErrorDisplayed() => NoDataError.Displayed;
    }
}
