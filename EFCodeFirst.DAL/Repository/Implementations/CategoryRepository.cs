using EFCodeFirst.DAL.DbContexts;
using EFCodeFirst.DAL.Entities;
using EFCodeFirst.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirst.DAL.Repository.Implementations
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Category entity)
        {
            _context.Categories.AddAsync(entity);
            _context.SaveChangesAsync();
        }

        public IEnumerable<Category> GetAll()
        {
            var categories = _context.Categories;
            return categories;
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Remove(Category entity)
        {
            _context.Categories.Remove(entity);
            _context.SaveChangesAsync();
        }

        public void Update(Category entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }
    }
}
