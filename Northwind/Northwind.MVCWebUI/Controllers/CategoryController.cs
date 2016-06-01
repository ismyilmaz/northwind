using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Interfaces;

namespace Northwind.MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategortService _categoryService;

        public CategoryController(ICategortService categoryService)
        {
            _categoryService = categoryService;
        }

        public PartialViewResult List(int category=0)
        {
            ViewBag.CurrentCategory = category;
            return PartialView(_categoryService.GetAll());
        }
    }
}