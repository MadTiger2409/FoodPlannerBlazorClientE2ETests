using OpenQA.Selenium.Interactions;

namespace FoodPlannerE2E.Pages.Controls
{
    public class BlazoredTypeahead
    {
        protected string InputXPath { get; private set; }

        protected IWebElement SearchboxInput => _driver.FindElement(By.XPath(InputXPath));
        protected IWebElement DownArrowButton => _driver.FindElement(By.XPath($"{InputXPath}/parent::div/div"));
        protected IList<IWebElement> SearchResults => _driver.FindElements(By.XPath($"{InputXPath}/ancestor::div[@class='blazored-typeahead valid']/div[@class='blazored-typeahead__results']/div"));

        protected readonly IWebDriver _driver;

        public BlazoredTypeahead(IWebDriver driver, string inputXPath)
        {
            _driver = driver;
            InputXPath = inputXPath;
        }

        public void Search(string filter) => SearchboxInput.SendKeys(filter);
        public void Expand() => DownArrowButton.Click();
        public void SelectByName(string name) => SearchResults.SingleOrDefault(x => x.Text == name).Click();
        public void SelectByIndex(int index) => SearchResults[index].Click();
    }
}
