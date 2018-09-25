using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.Models;

namespace WebStore.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T Find(int? id);
        void Add(T item);
        void Update(T item);
    }
}