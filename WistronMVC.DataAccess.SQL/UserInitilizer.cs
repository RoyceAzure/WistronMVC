using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WIstronMVC.Core.Models;

namespace WistronMVC.DataAccess.SQL
{
    public class UserInitilizer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
    {
        var Users = new List<User>
            {
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            },
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            },
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            },
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            },
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            },
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            },
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            },
            new User{Name="Carson",Email = "roycewnag@gmail.com", EnName="Alexander",Password="123456", Dep = "20", WorkNumber="123",MobelPhone = "123456",
                    TelPhone = "0229424717",ConfirmPas = "123456"
            }
            };

            Users.ForEach(s => context.User.Add(s));
        context.SaveChanges();

    }
}
}
