using System.Data.Entity;
using WIstronMVC.Core.Models;

namespace WistronMVC.DataAccess.SQL
{
    public class DataContext: DbContext
    {
        public DataContext() :
            base("DefaultConnection")
        { }

        public DbSet<User> User { get; set; }
    }
}
