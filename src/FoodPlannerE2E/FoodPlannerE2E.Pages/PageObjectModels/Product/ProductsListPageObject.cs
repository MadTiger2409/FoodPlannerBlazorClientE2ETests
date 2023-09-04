using FoodPlannerE2E.Core.Configs.PageLocators.Product;

namespace FoodPlannerE2E.Pages.PageObjectModels.Product
{
    public class ProductsListPageObject : BasePageObject<ProductsListPageLocators>
    {
        public ProductsListPageObject(IWebDriver driver) : base(driver)
        {
        }
    }
}
