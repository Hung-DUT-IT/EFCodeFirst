using EFCodeFirst.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.BAL.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
