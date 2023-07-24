using FoodPlannerE2E.ApiManager.Models.Common;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FoodPlannerE2E.ApiManager
{
    public class EntityApiService
    {
        private readonly HttpClient _client;
        private bool _disposed;

        public EntityApiService(HttpClient httpClient) => _client = httpClient;

        public async Task<TResponse> CreateAsync<TRequest, TResponse>(TRequest entity)
        {
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(entity));
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync("", httpContent);
            var contentAsString = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(contentAsString))
                throw new ArgumentException($"Got empty response while creating entity of type {typeof(TRequest).Name}");

            var responseObject = JsonConvert.DeserializeObject<ApiResponse<TResponse>>(contentAsString);

            if (!responseObject.Success)
            {
                var exception = new HttpRequestException(responseObject.Error.Title)
                {
                    Data = { ["Details"] = responseObject.Error.Details }
                };

                throw exception;
            }

            return responseObject.Value;
        }

        public async Task<bool> DeleteAsync(uint id)
        {
            var result = await _client.DeleteAsync(id.ToString());

            return result.IsSuccessStatusCode;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _client?.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~EntityApiService() => Dispose(false);
    }
}
