using FoodPlannerE2E.Core.Configs.PageLocators.Category;

namespace FoodPlannerE2E.Pages.PageObjectModels.Category
{
    public class CategoriesListPageObject : BasePageObject<CategoriesListPageLocators>
	{
		private IList<IWebElement> Categories { get => _driver.FindElements(By.XPath(Locators.Categories)); }

		public CategoriesListPageObject(IWebDriver driver) : base(driver) { }

		public void NavigateTo() => _driver.Navigate().GoToUrl($"{AppBaseHttpsUrl}/units");
		public bool ContainsUnitWithGivenName(string name) => Categories.Any(x => x.FindElement(By.TagName("a")).Text.Trim() == name);

	}
}
