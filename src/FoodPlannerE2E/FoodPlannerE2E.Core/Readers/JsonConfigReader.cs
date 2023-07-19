using System.Text.Json;

namespace FoodPlannerE2E.Core.Readers
{
    public class JsonConfigReader
    {
        private readonly string _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public async Task<T> GetJsonAsObjectAsync<T>() where T : class
        {
            var fileName = typeof(T).Name;
            var structure = typeof(T).Namespace.Remove(0, 20).Replace('.', '/');

            var jsonFileStream = File.OpenRead(Path.Combine(_baseDirectory, $"{structure}/{fileName}.json"));

            return await JsonSerializer.DeserializeAsync<T>(jsonFileStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public T GetJsonAsObject<T>() where T : class
        {
            var fileName = typeof(T).Name;
            var structure = typeof(T).Namespace.Remove(0, 20).Replace('.', '/');

            var jsonFileStream = File.OpenRead(Path.Combine(_baseDirectory, $"{structure}/{fileName}.json"));

            return JsonSerializer.Deserialize<T>(jsonFileStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
