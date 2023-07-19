using FoodPlannerE2E.Core.Configs;
using FoodPlannerE2E.Core.Readers;

namespace FoodPlannerE2E.Pages.PageObjectModels
{
    public class BasePageObject<TPageLocators> where TPageLocators : class
    {
        protected string AppBaseHttpUrl { get; private set; }
        protected string AppBaseHttpsUrl { get; private set; }
        protected TPageLocators Locators { get; private set; }
        protected JsonConfigReader ConfigReader { get; private set; }

        protected readonly IWebDriver _driver;

        public BasePageObject(IWebDriver driver)
        {
            _driver = driver;
            ConfigReader = new JsonConfigReader();
            var settings = ConfigReader.GetJsonAsObject<TestSolutionSettings>();
            Locators = ConfigReader.GetJsonAsObject<TPageLocators>();

            AppBaseHttpUrl = settings.ApplicationBaseHttpUrl;
            AppBaseHttpsUrl = settings.ApplicationBaseHttpsUrl;
        }
    }
}
