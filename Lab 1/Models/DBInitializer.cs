using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Lab_1.Models
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ShopBaseContext>
    {
        protected override void Seed(ShopBaseContext context)
        {
            base.Seed(context);
        }
    }
}