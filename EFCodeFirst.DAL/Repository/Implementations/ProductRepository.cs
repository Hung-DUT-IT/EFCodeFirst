using EFCodeFirst.DAL.DbContexts;
using EFCodeFirst.DAL.Entities;
using EFCodeFirst.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.DAL.Repository.Implementations
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        void IRepository<Product>.Add(Product entity)
        {
            _context.Products.AddAsync(entity);
            _context.SaveChangesAsync();
        }

        IEnumerable<Product> IRepository<Product>.GetAll()
        {
            var students = _context.Products;
            return students;
        }

        Product IRepository<Product>.GetById(int id)
        {
            return _context.Products.Find(id);
        }

        void IRepository<Product>.Remove(Product entity)
        {
            _context.Products.Remove(entity);
            _context.SaveChangesAsync();
        }

        void IRepository<Product>.Update(Product entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }
    }
}
