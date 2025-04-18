using DemoMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMicroservice.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<HotelBooking> Bookings { get; set; } = null!;
    }
}
