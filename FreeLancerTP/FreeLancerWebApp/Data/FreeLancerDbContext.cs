using FreeLancerWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeLancerWebApp.Data
{
    public class FreeLancerDbContext : DbContext
    {
        public DbSet<Customer> Customers
        {
            get; set;
        }
        public DbSet<CustomerCat> CustomersCats
        {
            get; set;
        }
        public DbSet<Job> Jobs
        {
            get; set;
        }
        public DbSet<Quote> Quotes
        {
            get; set;
        }

        public FreeLancerDbContext(DbContextOptions<FreeLancerDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerCat>().HasIndex(item => item.Name).IsUnique();
            builder.Entity<Customer>().HasIndex(item => item.Name).IsUnique();
            builder.Entity<Customer>().HasIndex(item => item.Email).IsUnique();
        }
    }
}