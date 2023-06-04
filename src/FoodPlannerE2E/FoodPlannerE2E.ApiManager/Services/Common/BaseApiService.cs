namespace FoodPlannerE2E.ApiManager.Services.Common
{
    public abstract class BaseApiService
    {
        public abstract TResponse Create<TResponse, TRequest>(TRequest entity);
        public abstract bool Delete(int id);
    }
}
