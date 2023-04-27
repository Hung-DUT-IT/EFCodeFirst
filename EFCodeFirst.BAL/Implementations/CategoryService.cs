using EFCodeFirst.BAL.Interfaces;
using EFCodeFirst.DAL.Entities;
using EFCodeFirst.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirst.BAL.Implementations
{
    public class CategoryService : IService<Category>
    {
        private readonly IRepository<Category> _productRepository;

        public CategoryService(IRepository<Category> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Category entity)
        {
            _productRepository.Add(entity);
        }

        public IEnumerable<Category> GetAll()
        {
            return _productRepository.GetAll();
        }
        
        public Category GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Remove(Category entity)
        {
            _productRepository.Remove(entity);
        }

        public void Update(Category entity)
        {
            _productRepository.Update(entity);
        }
    }
}
