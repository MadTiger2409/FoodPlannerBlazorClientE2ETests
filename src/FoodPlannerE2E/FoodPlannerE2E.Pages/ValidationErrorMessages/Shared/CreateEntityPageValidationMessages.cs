namespace FoodPlannerE2E.Pages.ValidationErrorMessages.Shared
{
	public static class CreateEntityPageValidationMessages
	{
		public static class Name
		{
			public static string CanNotBeEmpty { get; } = "Name can't be empty";
			public static string MustBeOfMinimumLength { get; } = "Name must be at least 2 characters long";
			public static string CanBeOfMaximumLength { get; } = "Name can be up to 100 characters long";
		}
	}
}
