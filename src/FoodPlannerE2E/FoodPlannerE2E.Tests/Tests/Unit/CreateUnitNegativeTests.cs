using FoodPlannerE2E.Pages.TextsAndMessages;
using FoodPlannerE2E.Tests.Fixtures.Unit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
    [TestFixture]
    [Category("Unit")]
    public class CreateUnitNegativeTests : CreateUnitFixture
    {
        private string _emptyName;
        private string _tooShortName;
        private string _tooLongName;

        [Test]
        public void Should_Not_Create_Unit_When_Name_Is_Empty()
        {
            CreateUnitPage.InsertName(_emptyName);
            CreateUnitPage.SendForm();

            CreateUnitPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanNotBeEmpty).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Unit_When_Name_Is_Too_Short()
        {
            CreateUnitPage.InsertName(_tooShortName);
            CreateUnitPage.SendForm();

            CreateUnitPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.MustBeOfMinimumLength).Should().BeTrue();
        }

        [Test]
        public void Should_Not_Create_Unit_When_Name_Is_Too_Long()
        {
            CreateUnitPage.InsertName(_tooLongName);
            CreateUnitPage.SendForm();

            CreateUnitPage.HasErrorMessageWithGivenText(CreateEntityPageMessages.Validation.Name.CanBeOfMaximumLength).Should().BeTrue();
        }

        protected override void PrepareTestData()
        {
            base.PrepareTestData();

            _emptyName = string.Empty;
            _tooShortName = ValueGenerator.GenerateString(1);
            _tooLongName = ValueGenerator.GenerateString(102);
        }
    }
}
