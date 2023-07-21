using FoodPlannerE2E.Pages.PageObjectModels.Category;
using FoodPlannerE2E.Tests.Fixtures.Common;

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
