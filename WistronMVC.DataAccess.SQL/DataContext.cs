using System.Data.Entity;
using WistronMVC.Core.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;


namespace WistronMVC.DataAccess.SQL
{
    public class DataContext: DbContext
    {
        public DataContext() :
            base("DefaultConnection")
        { }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
