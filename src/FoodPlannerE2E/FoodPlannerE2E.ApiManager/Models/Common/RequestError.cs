namespace FoodPlannerE2E.ApiManager.Models.Common
{
    public class RequestError
    {
        public string Title { get; set; }
        public List<string> Details { get; set; } = new();
    }
}
