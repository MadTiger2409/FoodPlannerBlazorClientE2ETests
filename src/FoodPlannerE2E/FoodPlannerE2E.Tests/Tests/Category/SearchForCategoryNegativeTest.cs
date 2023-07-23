using FoodPlannerE2E.Tests.Fixtures.Category;

namespace FoodPlannerE2E.Tests.Tests.Category
{
    [TestFixture]
    [Category("Category")]
    public class SearchForCategoryNegativeTest : SearchForCategoryFixture
    {
        private string _categoryNameToSearchFor;

        [Test]
        public void Should_Not_Find_Category_When_Entity_Does_Not_Exist()
        {
            CategoriesListPageObject.SearchForCategory(_categoryNameToSearchFor);

            CategoriesListPageObject.HasNoDataError().Should().BeTrue();
            CategoriesListPageObject.HasNoDataErrorDisplayed().Should().BeTrue();
            CategoriesListPageObject.HasNoDataErrorWithGivenText(EntitiesListPageMessages.Ui.EntitiesList.NoDataError).Should().BeTrue();
        }

        protected override void PrepareTestData()
        {
            base.PrepareTestData();

            _categoryNameToSearchFor = ValueGenerator.GenerateString(8) + "$";
        }
    }
}
