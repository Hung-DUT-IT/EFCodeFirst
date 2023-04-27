using EFCodeFirst.BAL.Interfaces;
using EFCodeFirst.DAL.Entities;
using EFCodeFirst.DAL.Repository.Implementations;
using EFCodeFirst.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.BAL.Implementations
{
    public class ProductService : IService<Product>
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        IEnumerable<Product> IService<Product>.GetAll()
        {
            return _productRepository.GetAll();
        }

        Product IService<Product>.GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        void IService<Product>.Add(Product entity)
        {
            _productRepository.Add(entity);
        }

        void IService<Product>.Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        void IService<Product>.Remove(Product entity)
        {
            _productRepository.Remove(entity);
        }
    }
}
