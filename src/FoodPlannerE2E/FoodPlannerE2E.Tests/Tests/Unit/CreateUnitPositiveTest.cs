using FluentAssertions;
using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using FoodPlannerE2E.Tests.Fixtures.Unit;
using Xunit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
	[Trait("Unit", "Create")]
	public sealed class CreateUnitPositiveTest : IClassFixture<CreateUnitFixture>
	{
		private const string ExpectedTitleHeaderText = "Success";
		private const string NewUnitName = "test";
		private string _actualTitleHeaderText;

		private readonly CreateUnitFixture _createUnitFixture;
		private readonly UnitsListPageObject _unitsListPageObject;

		public CreateUnitPositiveTest(CreateUnitFixture fixture)
		{
			_createUnitFixture = fixture;

			_unitsListPageObject = new(_createUnitFixture.DriverFixture.Driver);
		}

		[Fact]
		public void Should_Create_Unit_When_Name_Is_Correct()
		{
			_createUnitFixture.CreateUnitPage.InsertName(NewUnitName);
			_createUnitFixture.CreateUnitPage.SendForm();

			_actualTitleHeaderText = _createUnitFixture.ResponseStatusPage.TitleHeaderText;

			_unitsListPageObject.NavigateTo();

			_actualTitleHeaderText.Should().Be(ExpectedTitleHeaderText);
			_unitsListPageObject.ContainsUnitWithGivenName(NewUnitName).Should().BeTrue();
		}
	}
}
