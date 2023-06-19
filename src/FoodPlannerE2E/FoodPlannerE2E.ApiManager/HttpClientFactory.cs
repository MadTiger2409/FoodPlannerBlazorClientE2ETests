using FoodPlannerE2E.ApiManager.Enums;
using FoodPlannerE2E.Core.Configs;
using FoodPlannerE2E.Core.Tools;

namespace FoodPlannerE2E.ApiManager
{
    public static class HttpClientFactory
    {
        private static readonly JsonConfigReader _configReader = new JsonConfigReader();
        private static TestSolutionSettings _settings = _configReader.GetJsonAsObject<TestSolutionSettings>();

        public static HttpClient GetHttpClient(EntityType type)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "*/*");

            var uri = type switch
            {
                EntityType.Unit => new Uri($"{_settings.WebApiBaseHttpsUrl}/webapi/units/"),
                EntityType.Category => new Uri($"{_settings.WebApiBaseHttpsUrl}/webapi/categories/"),
                EntityType.Product => new Uri($"{_settings.WebApiBaseHttpsUrl}/webapi/products/"),
                EntityType.Meal => new Uri($"{_settings.WebApiBaseHttpsUrl}/webapi/meals/"),
                EntityType.PlannedMeal => new Uri($"{_settings.WebApiBaseHttpsUrl}/webapi/plannedMeals/"),
                EntityType.ShoppingList => new Uri($"{_settings.WebApiBaseHttpsUrl}/webapi/shoppingList/"),
                _ => new Uri(_settings.WebApiBaseHttpsUrl)
            };

            client.BaseAddress = uri;
            return client;
        }
    }
}
