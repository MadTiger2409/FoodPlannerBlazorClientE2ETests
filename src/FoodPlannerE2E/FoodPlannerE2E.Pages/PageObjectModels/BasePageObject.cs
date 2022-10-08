using FoodPlannerE2E.Core.Configs;
using FoodPlannerE2E.Core.Tools;
using OpenQA.Selenium;

namespace FoodPlannerE2E.Pages.PageObjectModels
{
    public class BasePageObject
    {
        protected string AppBaseHttpUrl { get; private set; }
        protected string AppBaseHttpsUrl { get; private set; }
        protected JsonConfigReader ConfigReader { get; private set; }

        protected readonly IWebDriver _driver;

        public BasePageObject(IWebDriver driver)
        {
            _driver = driver;
            ConfigReader = new JsonConfigReader();
            var settings = ConfigReader.GetJsonAsObject<TestSolutionSettings>();

            AppBaseHttpUrl = settings.ApplicationBaseHttpUrl;
            AppBaseHttpsUrl = settings.ApplicationBaseHttpsUrl;
        }
    }
}
