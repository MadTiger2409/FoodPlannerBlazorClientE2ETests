using FluentAssertions;
using FoodPlannerE2E.Tests.Fixtures.Unit;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
    [TestFixture]
    [Category("Unit")]
    public class DeleteUnitPositiveTest : DeleteUnitFixture
    {
        [Test]
        public void Should_Delete_Unit_When_Entity_Exists()
        {
            UnitsListPage.NavigateToUnitEditPage(UnitToDelete.Name);

            EditUnitPage.TriggerDeleteModal();
            DeleteEntityModal.ConfirmDeletion();

            UnitsListPage.ContainsUnitWithGivenName(UnitToDelete.Name).Should().BeFalse();
        }
    }
}
