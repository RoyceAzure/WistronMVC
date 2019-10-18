using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WistronMVC.Core.Models
{
    public abstract class BaseUser
    {
        public string Id { get; set; }
        public DateTimeOffset CreateAt;

        public BaseUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreateAt = DateTime.Now;

        }

    }
}
