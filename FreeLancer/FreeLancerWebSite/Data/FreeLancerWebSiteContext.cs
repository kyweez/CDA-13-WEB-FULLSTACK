using FreeLancerWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeLancerWebSite.Data
{
    public class FreeLancerWebSiteContext : DbContext
    {
        public DbSet<CustomerModel> Customers
        {
            get; set;
        }
        public DbSet<CustomerCatModel> CustomersCats
        {
            get; set;
        }
        public DbSet<JobModel> Jobs
        {
            get; set;
        }
        public DbSet<QuoteModel> Quotes
        {
            get; set;
        }

        public FreeLancerWebSiteContext(DbContextOptions<FreeLancerWebSiteContext> options) : base(options)
        {

        }

    }
}