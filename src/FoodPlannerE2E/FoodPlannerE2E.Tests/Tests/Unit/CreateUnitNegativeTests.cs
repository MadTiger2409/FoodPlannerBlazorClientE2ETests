using FluentAssertions;
using FoodPlannerE2E.Pages.ValidationErrorMessages;
using FoodPlannerE2E.Tests.Fixtures.Unit;
using NUnit.Framework;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
	[TestFixture]
	[Category("Unit")]
	public class CreateUnitNegativeTests : CreateUnitFixture
	{
		private const string EmptyName = "";
		private const string TooShortName = "X";
		private const string TooLongName = "a85150f56db84d5bab8f4b9d3a908b866b0d73b9440a492cbee5680afabad323372f8172bd44437fb20751f8855c3bc5b0814";

		[Test]
		public void Should_Not_Create_Unit_When_Name_Is_Empty()
		{
			CreateUnitPage.InsertName(EmptyName);
			CreateUnitPage.SendForm();

			CreateUnitPage.HasErrorMessageWithGivenText(CreateUnitPageValidationMessages.Name.CanNotBeEmpty).Should().BeTrue();
		}

		[Test]
		public void Should_Not_Create_Unit_When_Name_Is_Too_Short()
		{
			CreateUnitPage.InsertName(TooShortName);
			CreateUnitPage.SendForm();

			CreateUnitPage.HasErrorMessageWithGivenText(CreateUnitPageValidationMessages.Name.MustBeOfMinimumLength).Should().BeTrue();
		}

		[Test]
		public void Should_Not_Create_Unit_When_Name_Is_Too_Long()
		{
			CreateUnitPage.InsertName(TooLongName);
			CreateUnitPage.SendForm();

			CreateUnitPage.HasErrorMessageWithGivenText(CreateUnitPageValidationMessages.Name.CanBeOfMaximumLength).Should().BeTrue();
		}
	}
}
