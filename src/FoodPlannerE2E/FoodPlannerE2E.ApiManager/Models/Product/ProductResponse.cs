using FoodPlannerE2E.ApiManager.Models.Category;
using FoodPlannerE2E.ApiManager.Models.Common;

namespace FoodPlannerE2E.ApiManager.Models.Product
{
    public class ProductResponse : BaseResponse
    {
        public string Name { get; set; }
        public CategoryResponse Category { get; set; }
    }
}
