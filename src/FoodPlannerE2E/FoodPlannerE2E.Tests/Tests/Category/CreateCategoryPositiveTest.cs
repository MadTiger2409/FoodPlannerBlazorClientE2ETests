using FluentAssertions;
using FoodPlannerE2E.Pages.PageObjectModels.Category;
using FoodPlannerE2E.Tests.Fixtures.Category;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Tests.Category
{
    [TestFixture]
    [Category("Category")]
    public class CreateCategoryPositiveTest : CreateCategoryFixture
    {
        private const string ExpectedTitleHeaderText = "Success";
        private const string NewCategoryName = "test";
        private string _actualTitleHeaderText;

        private CategoriesListPageObject _categoriesListPageObject;

        [OneTimeSetUp]
        protected void TestSetup()
        {
            _categoriesListPageObject = new(Driver);
        }

        [Test]
        public void Should_Create_Category_When_Name_Is_Correct()
        {
            CreateCategoryPage.InsertName(NewCategoryName);
            CreateCategoryPage.SendForm();

            _actualTitleHeaderText = ResponseStatusCard.TitleText;

            _categoriesListPageObject.NavigateTo();

            _actualTitleHeaderText.Should().Be(ExpectedTitleHeaderText);
            _categoriesListPageObject.ContainsUnitWithGivenName(NewCategoryName).Should().BeTrue();
        }
    }
}
