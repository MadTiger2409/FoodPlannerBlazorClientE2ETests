using FoodPlannerE2E.Pages.PageObjectModels.Category;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Tests.Fixtures.Common;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Fixtures.Category
{
    public class CreateCategoryFixture : BaseTestFixture
    {
        protected CreateCategoryPageObject CreateCategoryPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCard { get; private set; }

        [OneTimeSetUp]
        protected override async Task Setup()
        {
            await base.Setup();
            CreateCategoryPage = new(Driver);
            ResponseStatusCard = new(Driver);

            CreateCategoryPage.NavigateTo();
        }
    }
}
