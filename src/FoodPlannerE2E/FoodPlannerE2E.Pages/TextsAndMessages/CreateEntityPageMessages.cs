namespace FoodPlannerE2E.Pages.TextsAndMessages
{
    public static class CreateEntityPageMessages
    {
        public static class Validation
        {
            public static class Name
            {
                public static string CanNotBeEmpty => "Name can't be empty";
                public static string MustBeOfMinimumLength => "Name must be at least 2 characters long";
                public static string CanBeOfMaximumLength => "Name can be up to 100 characters long";
            }

            public static class Typeahead
            {
                public static string MustBeSelected(string entityName) => $"{entityName} must be selected";
            }
        }
    }
}
