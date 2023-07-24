using FoodPlannerE2E.Pages.PageObjectModels.Unit;
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

        }

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _unitNewName = ValueGenerator.GenerateString(8);
        }
    }
}
