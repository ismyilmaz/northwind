using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Norhwind.Bll.Concrete;
using Norhwind.Entities;
using Northwind.Dal.Concrete.EntitiyFramework;
using Northwind.Interfaces;

namespace Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            List<Product> plist = _productService.GetAll();
            return View(plist);
        }
    }
}