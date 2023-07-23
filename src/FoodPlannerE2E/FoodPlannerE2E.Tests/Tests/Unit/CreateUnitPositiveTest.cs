using FoodPlannerE2E.Pages.PageObjectModels.Shared;
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
        private EditUnitPageObject _editUnitPageObject;
        private DeleteEntityModalPageObject _deleteEntityModal;

        [Test]
        public void Should_Create_Unit_When_Name_Is_Correct()
        {
            CreateUnitPage.InsertName(_newUnitName);
            CreateUnitPage.SendForm();

            _actualTitleHeaderText = ResponseStatusCard.TitleText;

            _unitsListPageObject.NavigateTo();

            _actualTitleHeaderText.Should().Be(ResponseStatusCardPageMessages.Ui.Title.Success);
            _unitsListPageObject.ContainsUnitWithGivenName(_newUnitName).Should().BeTrue();
        }

        [OneTimeSetUp]
        public void TestSetup()
        {
            _unitsListPageObject = new(Driver);
            _editUnitPageObject = new(Driver);
            _deleteEntityModal = new(Driver);
        }

        [OneTimeTearDown]
        public void TestCleanup()
        {
            _unitsListPageObject.NavigateToEditPage(_newUnitName);

            _editUnitPageObject.TriggerDeleteModal();
            _deleteEntityModal.ConfirmDeletion();
        }

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _newUnitName = ValueGenerator.GenerateString(8);
        }
    }
}
