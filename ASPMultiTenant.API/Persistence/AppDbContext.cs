using ASPMultiTenant.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASPMultiTenant.API.Persistence;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }


    public DbSet<Customer> Customers { get; set; }

}