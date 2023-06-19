using FluentAssertions;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Tests.Fixtures.Unit;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
    [TestFixture]
    [Category("Unit")]
    public class CreateUnitPositiveTest : CreateUnitFixture
    {
        private const string ExpectedTitleHeaderText = "Success";
        private const string NewUnitName = "test";
        private string _actualTitleHeaderText;

        private UnitsListPageObject _unitsListPageObject;

        [OneTimeSetUp]
        protected void TestSetup()
        {
            _unitsListPageObject = new(Driver);
        }

        [Test]
        public void Should_Create_Unit_When_Name_Is_Correct()
        {
            CreateUnitPage.InsertName(NewUnitName);
            CreateUnitPage.SendForm();

            _actualTitleHeaderText = ResponseStatusCard.TitleText;

            _unitsListPageObject.NavigateTo();

            _actualTitleHeaderText.Should().Be(ExpectedTitleHeaderText);
            _unitsListPageObject.ContainsUnitWithGivenName(NewUnitName).Should().BeTrue();
        }
    }
}
