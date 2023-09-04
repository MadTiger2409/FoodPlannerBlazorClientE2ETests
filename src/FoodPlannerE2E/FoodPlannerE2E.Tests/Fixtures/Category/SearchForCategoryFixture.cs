using FoodPlannerE2E.Pages.PageObjectModels.Category;

namespace FoodPlannerE2E.Tests.Fixtures.Category
{
    public class SearchForCategoryFixture : BaseTestFixture
    {
        protected CategoriesListPageObject CategoriesListPageObject { get; private set; }

        [OneTimeSetUp]
        protected void Setup()
        {
            CategoriesListPageObject = new(Driver);

            CategoriesListPageObject.NavigateTo();
        }
    }
}
