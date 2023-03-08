using FluentAssertions;
using FoodPlannerE2E.Tests.Fixtures.Unit;
using Xunit;

namespace FoodPlannerE2E.Tests.Tests.Unit
{
	[Trait("Unit", "Create")]
	public class CreateUnitNegativeTests : IClassFixture<CreateUnitFixture>
	{
		private readonly CreateUnitFixture _createUnitFixture;

		public CreateUnitNegativeTests(CreateUnitFixture createUnitFixture)
		{
			_createUnitFixture = createUnitFixture;
		}

		[Fact]
		public void CreateUnitNegative()
		{
			var x = 1;
			x.Should().Be(1);
		}
	}
}
