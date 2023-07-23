namespace FoodPlannerE2E.Pages.Extensions
{
    public static class DriverExtensionMethods
    {
        public static bool DoesPageHaveExactlyOneElement(this IWebDriver driver, By by) => driver.FindElements(by).Count == 1;
    }
}
