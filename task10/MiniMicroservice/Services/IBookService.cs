using MiniMicroservice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniMicroservice.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task<Book> CreateAsync(Book book);
        Task<Book?> UpdateAsync(int id, Book book);
        Task<bool> DeleteAsync(int id);
    }
}
