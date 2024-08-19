using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UmbracoWebsites.Models;

namespace UmbracoWebsites.Data
{
    public class IceCreamContext : DbContext
    {

        public IceCreamContext() : base("NFU_Custom_Website_DataConnectionString")
        {
        }

        public DbSet<IceCreamVendor> IceCreamVendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IceCreamVendor>();
        }

    }
}