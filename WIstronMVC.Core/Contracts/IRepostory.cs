using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WistronMVC.Core.Models;

namespace WIstronMVC.Core.Contracts
{
    public interface IRepostory<T> where T :BaseUser
    {
        void Commit();

        void Insert(T t);

        void Update(T t);

        void Delete(string Id);

        T Find(string Id);

        IQueryable<T> Collection();


    }
}
