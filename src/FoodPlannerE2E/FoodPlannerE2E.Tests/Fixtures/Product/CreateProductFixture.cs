using FoodPlannerE2E.Pages.PageObjectModels.Product;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;

namespace FoodPlannerE2E.Tests.Fixtures.Product
{
    public class CreateProductFixture : BaseTestFixture
    {
        protected CreateProductPageObject CreateProductPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCard { get; private set; }

        [OneTimeSetUp]
        protected void Setup()
        {
            CreateProductPage = new(Driver);
            ResponseStatusCard = new(Driver);

            CreateProductPage.NavigateTo();
        }
    }
}
