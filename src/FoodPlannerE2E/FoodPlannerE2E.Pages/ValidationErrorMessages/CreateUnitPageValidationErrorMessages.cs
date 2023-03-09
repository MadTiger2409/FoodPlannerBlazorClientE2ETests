namespace FoodPlannerE2E.Pages.ValidationErrorMessages
{
	public static class CreateUnitPageValidationErrorMessages
	{
		public static string NameCantBeEmptyMessage { get; } = "Name can't be empty";
		public static string NameMinimumLengthMessage { get; } = "Name must be at least 2 characters long";
		public static string NameMaximumLengthMessage { get; } = "Name can be up to 100 characters long";
	}
}
