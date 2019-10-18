using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using WistronMVC.Core.Models;
using WIstronMVC.Core.Contracts;

namespace WistronMVC.DataAccess.InMemory
{
    public class MemoryReopstory<T> : IRepostory<T> where T : BaseUser
    {
        ObjectCache Cache = MemoryCache.Default;
        List<T> items;
        string className;

        public MemoryReopstory()
        {
            className = typeof(T).Name;
            items = Cache[className] as List<T>;
            if (items == null)
                items = new List<T>();
        }
        public IQueryable<T> Collection()
        {
            return items.AsQueryable();
        }

        public void Commit()
        {
            Cache[className] = items;
        }

        public void Delete(string Id)
        {
            T item = items.Find(c=> c.Id == Id);
            if (item == null)
                throw new Exception(className + " Not found");
            items.Remove(item);
        }

        public T Find(string Id)
        {
            T item = items.Find(c => c.Id == Id);
            if (item == null)
                throw new Exception(className + " Not found");
            return item;
        }

        public void Insert(T t)
        {
            items.Add(t);
        }

        public void Update(T t)
        {
            T itemToUpdate = items.Find(c => c.Id == t.Id);
            if (itemToUpdate == null)
                throw new Exception(className + " Not found");
            itemToUpdate = t;
        }
    }
}
