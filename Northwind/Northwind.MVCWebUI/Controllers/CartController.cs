using System.Web.Mvc;
using Norhwind.Entities;
using Northwind.Interfaces;

namespace Northwind.MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public RedirectToRouteResult AddToCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);
            
            cart.AddToCart(product, 1);
            return RedirectToAction("Index", cart);
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);

            cart.RemoveFromCart(product);

            return RedirectToAction("Index", cart);
        }

        public ActionResult Index(Cart cart)
        {
            return View(cart);
        }

        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            return View(shippingDetails);

        }

        public PartialViewResult CartSummary(Cart cart)
        {
            return PartialView(cart);
        }
    }
}