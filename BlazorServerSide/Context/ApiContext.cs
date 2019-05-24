using BlazorServerSide.ViewModel;
using Microsoft.EntityFrameworkCore;    

namespace BlazorServerSide.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}