using FoodPlannerE2E.Tests.Fixtures.Unit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
    [TestFixture]
    [Category("Unit")]
    public class DeleteUnitPositiveTest : DeleteUnitFixture
    {
        [Test]
        public void Should_Delete_Unit_When_Entity_Exists()
        {
            UnitsListPage.NavigateToEditPage(UnitToDelete.Name);

            EditUnitPage.TriggerDeleteModal();
            DeleteEntityModal.ConfirmDeletion();

            UnitsListPage.ContainsUnitWithGivenName(UnitToDelete.Name).Should().BeFalse();
        }
    }
}
