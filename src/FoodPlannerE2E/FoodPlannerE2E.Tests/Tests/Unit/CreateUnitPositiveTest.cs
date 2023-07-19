using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Pages.TextsAndMessages.Shared;
using FoodPlannerE2E.Tests.Fixtures.Unit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
    [TestFixture]
    [Category("Unit")]
    public class CreateUnitPositiveTest : CreateUnitFixture
    {
        private string _newUnitName;
        private string _actualTitleHeaderText;

        private UnitsListPageObject _unitsListPageObject;

        [Test]
        public void Should_Create_Unit_When_Name_Is_Correct()
        {
            CreateUnitPage.InsertName(_newUnitName);
            CreateUnitPage.SendForm();

            _actualTitleHeaderText = ResponseStatusCard.TitleText;

            _unitsListPageObject.NavigateTo();

            _actualTitleHeaderText.Should().Be(ResponseStatusCardPageMessages.Ui.Title.Success);
            _unitsListPageObject.ContainsUnitWithGivenName(_newUnitName.ToLowerInvariant()).Should().BeTrue();
        }

        [OneTimeSetUp]
        protected void TestSetup() => _unitsListPageObject = new(Driver);

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _newUnitName = ValueGenerator.GenerateString(8);
        }
    }
}
