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
		private const string TooShortName = "X";
		private const string TooLongName = "a85150f56db84d5bab8f4b9d3a908b866b0d73b9440a492cbee5680afabad323372f8172bd44437fb20751f8855c3bc5b0814";

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

			_createUnitFixture.CreateUnitPage.HasErrorMessageWithGivenText(CreateUnitPageValidationMessages.Name.CanNotBeEmpty).Should().BeTrue();
		}

		[Fact]
		public void Should_Not_Create_Unit_When_Name_Is_Too_Short()
		{
			_createUnitFixture.CreateUnitPage.InsertName(TooShortName);
			_createUnitFixture.CreateUnitPage.SendForm();

			_createUnitFixture.CreateUnitPage.HasErrorMessageWithGivenText(CreateUnitPageValidationMessages.Name.MustBeOfMinimumLength).Should().BeTrue();
		}

		[Fact]
		public void Should_Not_Create_Unit_When_Name_Is_Too_Long()
		{
			_createUnitFixture.CreateUnitPage.InsertName(TooLongName);
			_createUnitFixture.CreateUnitPage.SendForm();

			_createUnitFixture.CreateUnitPage.HasErrorMessageWithGivenText(CreateUnitPageValidationMessages.Name.CanBeOfMaximumLength).Should().BeTrue();
		}
	}
}
