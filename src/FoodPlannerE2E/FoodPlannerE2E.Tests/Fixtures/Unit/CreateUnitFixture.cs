using FoodPlannerE2E.Pages.PageObjectModels.Shared;
using FoodPlannerE2E.Pages.PageObjectModels.Unit;
using System;

namespace FoodPlannerE2E.Tests.Fixtures.Unit
{
	public class CreateUnitFixture : IDisposable
	{
		public DriverFixture DriverFixture { get; }
		public CreateUnitPageObject CreateUnitPage { get; }
		public ResponseStatusPageObject ResponseStatusPage { get; }

		public CreateUnitFixture()
		{
			DriverFixture = new();

			CreateUnitPage = new(DriverFixture.Driver);
			ResponseStatusPage = new(DriverFixture.Driver);

			CreateUnitPage.NavigateTo();
		}

		public void Dispose()
		{
			DriverFixture.Dispose();
		}
	}
}
