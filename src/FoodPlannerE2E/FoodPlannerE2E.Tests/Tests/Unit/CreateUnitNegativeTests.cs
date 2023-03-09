using FluentAssertions;
using FoodPlannerE2E.Pages.ValidationErrorMessages;
using FoodPlannerE2E.Tests.Fixtures.Unit;
using Xunit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
	[Trait("Unit", "Create")]
	public class CreateUnitNegativeTests : IClassFixture<CreateUnitFixture>
	{
		private const string EmptyName = "";

		private readonly CreateUnitFixture _createUnitFixture;

		public CreateUnitNegativeTests(CreateUnitFixture createUnitFixture)
		{
			_createUnitFixture = createUnitFixture;
		}

		[Fact]
		public void Should_Not_Create_Unit_When_Name_Is_Empty()
		{
			_createUnitFixture.CreateUnitPage.InsertName(EmptyName);
			_createUnitFixture.CreateUnitPage.SendForm();

			_createUnitFixture.CreateUnitPage.HasErrorMessageWithGivenText(CreateUnitPageValidationErrorMessages.NameCantBeEmptyMessage).Should().BeTrue();
		}
	}
}
