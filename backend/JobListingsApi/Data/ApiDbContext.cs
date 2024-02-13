using JobListingsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JobListingsApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
        public DbSet<Job> Jobs { get; set; }
    }
}
