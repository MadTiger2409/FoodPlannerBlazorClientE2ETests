using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Pages.TextsAndMessages.Shared;
using FoodPlannerE2E.Tests.Fixtures.Unit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
    [TestFixture]
    [Category("Unit")]
    public class EditUnitPositiveTest : EditUnitFixture
    {
        private UnitsListPageObject _unitsListPage;
        private string _unitNewName;

        [Test]
        public void Should_Edit_Unit_When_Name_Is_Correct()
        {
            EditUnitPage.ChangeFormEditability();
            EditUnitPage.InsertName(_unitNewName);
            EditUnitPage.SendForm(1);

            ResponseStatusCardPage.IsInSuccessState().Should().BeTrue();
            ResponseStatusCardPage.HasSuccessMessageWithGivenText(ResponseStatusCardPageMessages.Ui.Messages.EntityUpdatedSuccessfully("Unit")).Should().BeTrue();

            _unitsListPage.NavigateTo();
            _unitsListPage.ContainsUnitWithGivenName(_unitNewName).Should().BeTrue();
        }

        [OneTimeSetUp]
        public void TestSetup() => _unitsListPage = new(Driver);

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _unitNewName = ValueGenerator.GenerateString(8);
        }
    }
}
