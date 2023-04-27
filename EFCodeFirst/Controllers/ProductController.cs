using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirst.BAL.Interfaces;
using EFCodeFirst.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirst.Controllers
{
    public class ProductController : Controller
    {
        private readonly IService<Product> _productService;

        public ProductController(IService<Product> productService)
        {
            this._productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}