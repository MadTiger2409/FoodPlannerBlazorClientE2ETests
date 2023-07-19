using FoodPlannerE2E.Core.Configs.PageLocators.Shared;

namespace FoodPlannerE2E.Pages.PageObjectModels.Shared
{
    public class DeleteEntityModalPageObject : BasePageObject<DeleteEntityModalLocators>
    {
        protected IWebElement Body { get => _driver.FindElement(By.XPath(Locators.Body)); }
        protected IWebElement Title { get => _driver.FindElement(By.XPath(Locators.Title)); }
        protected IWebElement Message { get => _driver.FindElement(By.XPath(Locators.Message)); }
        protected IWebElement NoButton { get => _driver.FindElement(By.XPath(Locators.NoButton)); }
        protected IWebElement YesButton { get => _driver.FindElement(By.XPath(Locators.YesButton)); }

        public DeleteEntityModalPageObject(IWebDriver driver) : base(driver) { }

        public bool TitleContainsGivenText(string text) => Title.Text.Contains(text);
        public bool MessageContainsGivenText(string text) => Message.Text.Contains(text);
        public void DeclineDeletion() => NoButton.Click();
        public void ConfirmDeletion() => YesButton.Click();
    }
}
