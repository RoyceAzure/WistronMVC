using System;
using System.Data.Entity;
using System.Linq;
using WistronMVC.Core.Models;
using WistronMVC.Core.Contracts;

namespace WistronMVC.DataAccess.SQL
{
    public class SQLRepostory<T> : IRepostory<T> where T : BaseUser
    {
        DataContext context;
        DbSet<T> Dbset;
        public SQLRepostory(DataContext context)
        {
            this.context = context;
            Dbset = context.Set<T>();
        }
        public IQueryable<T> Collection()
        {
            return Dbset;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Delete(string Id)
        {
            var t = Find(Id);
            if (context.Entry(t).State == EntityState.Detached)
                Dbset.Attach(t);
            Dbset.Remove(t);
        }

        public T Find(string Id)
        {
            return Dbset.Find(Id);
        }

        public void Insert(T t)
        {
            Dbset.Add(t);
        }

        public void Update(T t)
        {
            Dbset.Attach(t);
            context.Entry(t).State = EntityState.Modified;
        }
    }
}
