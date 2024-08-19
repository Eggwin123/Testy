using UmbracoWebsites.Models;
using System.Data.Entity;

namespace UmbracoWebsites.Data
{
    public class TurkeyFinderContext : DbContext
    {
        public TurkeyFinderContext() : base("NFU_Custom_Website_DataConnectionString")
        {
        }

        public DbSet<TurkeyBusiness> TurkeyBusinesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurkeyBusiness>().Ignore(i => i.Miles);
            modelBuilder.Entity<TurkeyBusiness>().ToTable("TurkeyFinder_Businesses");
        }
    }
}