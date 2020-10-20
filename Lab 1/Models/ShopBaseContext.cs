using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab_1.Models
{
    public class ShopBaseContext :DbContext
    {
        public ShopBaseContext() : base("name=ShopBaseContext") { }

        public System.Data.Entity.DbSet<Lab_1.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Lab_1.Models.Product> Instruments { get; set; }

        public System.Data.Entity.DbSet<Lab_1.Models.Orders> Orders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        static ShopBaseContext()
        {
            Database.SetInitializer(new DBInitializer());
        }
        
    }
}