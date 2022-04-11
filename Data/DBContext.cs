#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using W21_Assignment.Model;

public class DBContext : IdentityDbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Product { get; set; }
    public DbSet<SiteUser> SiteUser { get; set; }
    public DbSet<Cart> Cart { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Stock> Stock { get; set; }

    public DbSet<Menu> Menu { get; set; }

    public DbSet<Coffee> Coffee { get; set; }
}
