using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;

namespace VaultUI.Http
{
    public class ApiClient
    {
        //private readonly IHttpClientFactory _httpClient;
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClientFactory)
        {
            _httpClient = httpClientFactory;
        }

        public async Task<T?> GetAsync<T>(string url)
        {
            using var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode) 
                return default;
            
            var stream = await response.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<T>(stream,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                });
        }

        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest data)
        {
            using var response = await _httpClient.PostAsJsonAsync(url, data);

            if (!response.IsSuccessStatusCode)
                return default;

            return await response.Content.ReadFromJsonAsync<TResponse>();
        }
    }
}
