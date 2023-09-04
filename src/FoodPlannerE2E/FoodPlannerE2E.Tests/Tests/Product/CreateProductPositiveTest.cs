using FoodPlannerE2E.Pages.PageObjectModels.Product;
using FoodPlannerE2E.Tests.Fixtures.Product;

namespace FoodPlannerE2E.Tests.Tests.Product
{
    [TestFixture]
    [Category("Product")]
    public class CreateProductPositiveTest : CreateProductFixture
    {
        private string _newProductName;
        private string _actualTitleHeaderText;

        private ProductsListPageObject _productsListPageObject;

        [OneTimeSetUp]
        protected void TestSetup() => _productsListPageObject = new(Driver);

        //TODO Add teardown to delete newly added product

        protected override void PrepareTestData()
        {
            base.PrepareTestData();
            _newProductName = ValueGenerator.GenerateString(10);
        }
    }
}
