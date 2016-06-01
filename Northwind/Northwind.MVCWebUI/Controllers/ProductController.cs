using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Norhwind.Bll.Concrete;
using Norhwind.Entities;
using Northwind.Dal.Concrete.EntitiyFramework;
using Northwind.Interfaces;
using Northwind.MVCWebUI.Models;
using PagedList;
using PagedList.Mvc;


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

        public int PageSize = 5;
        public ActionResult Index(int page = 1,int category=0)
        {
            List<Product> plist = _productService.GetAll().Where(c=>c.CategoryID== category || category== 0).ToList();
            return View(new ProductViewModel
            {
                Products = plist.Skip((page - 1) * PageSize).Take(5).ToList(),
                PageInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = plist.Count,
                    CurrentPage = page,
                    CurrentCategory=category
                }
            });
        }

        
        // MVC paged list kullanımı
        //public ActionResult Index(int? page)
        //{
        //    var plist = _productService.GetAll().ToPagedList(page ?? 1, 3);
        //    return View(plist);
        //}
    }
}