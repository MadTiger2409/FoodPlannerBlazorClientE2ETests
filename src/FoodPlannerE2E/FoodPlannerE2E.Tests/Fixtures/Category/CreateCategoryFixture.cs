﻿using FoodPlannerE2E.Pages.PageObjectModels.Category;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Tests.Fixtures.Common;

namespace FoodPlannerE2E.Tests.Fixtures.Category
{
    public class CreateCategoryFixture : BaseTestFixture
    {
        protected CreateCategoryPageObject CreateCategoryPage { get; private set; }
        protected ResponseStatusCardPageObject ResponseStatusCard { get; private set; }

        [OneTimeSetUp]
        protected void Setup()
        {
            CreateCategoryPage = new(Driver);
            ResponseStatusCard = new(Driver);

            CreateCategoryPage.NavigateTo();
        }
    }
}
