using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WistronMVC.DataAccess.SQL;
using WIstronMVC.Core.Models;

namespace WistronMVC.SQL.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext())
            {
                db.User.Add(new User
                {
                    Name = "Carson",
                    Email = "roycewnag@gmail.com",
                    EnName = "Alexander",
                    Password = "123456",
                    Dep = "20",
                    WorkNumber = "123",
                    MobelPhone = "123456",
                    TelPhone = "0229424717",
                    ConfirmPas = "123456"
                });
                db.SaveChanges();

                foreach (var user in db.User)
                {
                    Console.WriteLine(user.Name);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
