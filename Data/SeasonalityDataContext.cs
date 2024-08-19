using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UmbracoWebsites.Models.Seasonality;

namespace UmbracoWebsites.Data
{
    public class SeasonalityDataContext : DbContext
    {
        public SeasonalityDataContext() : base("NFU_Custom_Website_DataConnectionString") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasRequired(p => p.Category);
            modelBuilder.Entity<Product>().ToTable("SeasonalityChart");
            modelBuilder.Entity<Category>().ToTable("SeasonalityChart_Category");
        }
    }
}