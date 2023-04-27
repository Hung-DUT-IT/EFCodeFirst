using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirst.BAL.Interfaces;
using EFCodeFirst.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirst.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IService<Category> _categoryService;

        public CategoryController(IService<Category> categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetAll();
            return View(categories);
        }
    }
}