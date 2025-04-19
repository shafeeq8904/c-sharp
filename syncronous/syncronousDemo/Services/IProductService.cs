using syncronousDemo.Models;

namespace syncronousDemo.Services
{
    public interface IProductService
    {
        Task<Product?> GetProductByIdAsync(int id);
    }
}
