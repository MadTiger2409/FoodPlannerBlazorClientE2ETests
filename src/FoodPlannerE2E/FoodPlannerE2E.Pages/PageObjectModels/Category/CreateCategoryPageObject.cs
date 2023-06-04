using FoodPlannerE2E.Core.Configs.PageLocators.Category;
using OpenQA.Selenium;

namespace FoodPlannerE2E.Pages.PageObjectModels.Category
{
    public class CreateCategoryPageObject : BasePageObject<CreateCategoryPageLocators>
	{
		protected IWebElement NameTextBox { get => _driver.FindElement(By.XPath(Locators.NameTextInput)); }
		protected IList<IWebElement> NameErrorMessages { get => _driver.FindElements(By.XPath(Locators.NameErrorMessage)); }
		protected IWebElement SendButton { get => _driver.FindElement(By.XPath(Locators.SendButton)); }

		public CreateCategoryPageObject(IWebDriver driver) : base(driver) { }

		public void InsertName(string name)
		{
			NameTextBox.Clear();
			NameTextBox.SendKeys(name);
		}

		public bool HasErrorMessageWithGivenText(string message) => NameErrorMessages.Any(x => x.Text.Trim().ToLowerInvariant() == message.ToLowerInvariant());
		public void SendForm() => SendButton.Click();
		public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/categories/new");
	}
}
