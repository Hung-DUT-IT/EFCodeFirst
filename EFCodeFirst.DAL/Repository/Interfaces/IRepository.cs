using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.DAL.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
