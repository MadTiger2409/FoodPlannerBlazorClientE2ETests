using FoodPlannerE2E.Pages.PageObjectModels.Category;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Fixtures.Category
{
    public class CreateCategoryFixture : DriverFixture
    {
        protected CreateCategoryPageObject CreateCategoryPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCard { get; private set; }

        [OneTimeSetUp]
        protected override void Setup()
        {
            base.Setup();
            CreateCategoryPage = new(Driver);
            ResponseStatusCard = new(Driver);

            CreateCategoryPage.NavigateTo();
        }
    }
}
