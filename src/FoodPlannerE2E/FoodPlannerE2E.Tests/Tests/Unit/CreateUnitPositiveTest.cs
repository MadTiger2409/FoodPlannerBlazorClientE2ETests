using FluentAssertions;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Tests.Fixtures;
using Xunit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
	[Trait("Unit", "Create")]
	public sealed class CreateUnitPositiveTest : BaseTest
	{
		private const string ExpectedTitleHeaderText = "Success";
		private const string NewUnitName = "test";
		private string _actualTitleHeaderText;

		private readonly CreateUnitPageObject _createUnitPage;
		private readonly UnitsListPageObject _unitsListPageObject;
		private readonly ResponseStatusPageObject _responseStatusPage;

		public CreateUnitPositiveTest(DriverFixture fixture) : base(fixture)
		{
			_createUnitPage = new(Driver);
			_unitsListPageObject = new(Driver);
			_responseStatusPage = new(Driver);
		}

		[Fact]
		public void Should_Create_Unit()
		{
			_createUnitPage.NavigateTo();
			_createUnitPage.InsertName(NewUnitName);
			_createUnitPage.SendForm();

			_actualTitleHeaderText = _responseStatusPage.TitleHeaderText;

			_unitsListPageObject.NavigateTo();

			_actualTitleHeaderText.Should().Be(ExpectedTitleHeaderText);
			_unitsListPageObject.ContainsUnitWithGivenName(NewUnitName).Should().BeTrue();
		}
	}
}
