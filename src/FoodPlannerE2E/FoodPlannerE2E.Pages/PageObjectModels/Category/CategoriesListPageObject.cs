using FoodPlannerE2E.Core.Configs.PageLocators.Category;

namespace FoodPlannerE2E.Pages.PageObjectModels.Category
{
    public class CategoriesListPageObject : BasePageObject<CategoriesListPageLocators>
    {
        protected IWebElement NameTextBox => _driver.FindElement(By.XPath(Locators.NameTextInput));
        protected IWebElement SendButton => _driver.FindElement(By.XPath(Locators.SendButton));
        protected IList<IWebElement> Categories => _driver.FindElements(By.XPath(Locators.Categories));

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

        //TODO Change it because categories list doesn't have <a> inside <li>
        public bool ContainsUnitWithGivenName(string name) => Categories.Any(x => x.Text.Trim() == name);
    }
}
