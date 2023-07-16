using FluentAssertions;
using FoodPlannerE2E.Pages.TextsAndMessages;
using FoodPlannerE2E.Tests.Fixtures.Category;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Tests.Category
{
    [TestFixture]
    [Category("Category")]
    public class CreateCategoryNegativeTests : CreateCategoryFixture
    {
        private const string EmptyName = "";
        private const string TooShortName = "X";
        private const string TooLongName = "a85150f56db84d5bab8f4b9d3a908b866b0d73b9440a492cbee5680afabad323372f8172bd44437fb20751f8855c3bc5b0814";

        [Test]
        public void Should_Not_Create_Category_When_Name_Is_Empty()
        {
            CreateCategoryPage.InsertName(EmptyName);
            CreateCategoryPage.SendForm();

            CreateCategoryPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanNotBeEmpty).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Category_When_Name_Is_Too_Short()
        {
            CreateCategoryPage.InsertName(TooShortName);
            CreateCategoryPage.SendForm();

            CreateCategoryPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.MustBeOfMinimumLength).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Category_When_Name_Is_Too_Long()
        {
            CreateCategoryPage.InsertName(TooLongName);
            CreateCategoryPage.SendForm();

            CreateCategoryPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanBeOfMaximumLength).Should().BeTrue();
        }
    }
}
