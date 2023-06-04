using FoodPlannerE2E.ApiManager.Services.Common;

namespace FoodPlannerE2E.ApiManager.Services
{
    public class UnitApiService : BaseApiService
    {
        public override TResponse Create<TResponse, TRequest>(TRequest entity) => throw new NotImplementedException();
        public override bool Delete(int id) => throw new NotImplementedException();
    }
}
