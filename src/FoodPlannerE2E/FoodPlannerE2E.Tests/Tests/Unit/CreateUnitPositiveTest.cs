using FluentAssertions;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Tests.Fixtures;
using Xunit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
    [Trait("Unit", "Create")]
    public class CreateUnitPositiveTest : BaseTest
    {
        public CreateUnitPageObject CreateUnitPage { get; set; }
        public ResponseStatusPageObject ResponseStatusPage { get; set; }

        public CreateUnitPositiveTest(DriverFixture fixture) : base(fixture)
        {
            CreateUnitPage = new(Driver);
            ResponseStatusPage = new(Driver);
        }

        [Fact]
        public void Should_Create_Unit()
        {
            CreateUnitPage.NavigateTo();
            CreateUnitPage.InsertName("test");
            CreateUnitPage.SendForm();

            ResponseStatusPage.TitleHeaderText.Should().Be("Success");
        }
    }
}
