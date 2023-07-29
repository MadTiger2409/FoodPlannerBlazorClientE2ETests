namespace FoodPlannerE2E.Pages.TextsAndMessages.Shared
{
    public static class ResponseStatusCardPageMessages
    {
        public static class Ui
        {
            public static class Title
            {
                public static string Success => "Success";
            }

            public static class Messages
            {
                public static string EntityWithIdNotFound => "Entity with the given id could not be found.";
                public static string EntityAlreadyExists(string entityCurrentName) => $"Entity '{entityCurrentName}' already exists.";
                public static string EntityUpdatedSuccessfully(string entityTypeName) => $"{entityTypeName} updated successfully";
            }
        }
    }
}
