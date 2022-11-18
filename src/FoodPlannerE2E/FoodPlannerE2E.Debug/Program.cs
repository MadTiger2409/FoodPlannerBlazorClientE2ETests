using FoodPlannerE2E.Core.Configs;
using FoodPlannerE2E.Core.Configs.PageLocators.Shared;
using FoodPlannerE2E.Core.Tools;
using System;
using System.Threading.Tasks;

namespace FoodPlannerE2E.Debug
{
    public static class Program
    {
        public static async Task Main()
        {
            var reader = new JsonConfigReader();

            //var locators = await reader.GetJsonAsObjectAsync<CreateUnitPageLocators>();
            var locators = await reader.GetJsonAsObjectAsync<ResponseStatusPageLocators>();
            var settings = await reader.GetJsonAsObjectAsync<TestSolutionSettings>();

            Console.WriteLine(locators.BodyDiv);
            Console.WriteLine(locators.TitleHeader);
            Console.WriteLine(locators.CloseButton);
            Console.WriteLine();
            Console.WriteLine(settings.ApplicationBaseHttpUrl);
            Console.WriteLine(settings.ApplicationBaseHttpsUrl);
        }
    }
}
