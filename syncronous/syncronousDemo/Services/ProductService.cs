using Newtonsoft.Json;
using syncronousDemo.Models;

namespace syncronousDemo.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://fakestoreapi.com/products/{id}");
            if (!response.IsSuccessStatusCode) return null;

            var content = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<Product>(content);
            return product;
        }
    }
}
