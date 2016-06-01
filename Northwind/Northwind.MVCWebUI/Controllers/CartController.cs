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
        public RedirectToRouteResult AddToCart(int productId)
        {
            Product product = _productService.Get(productId);

            Cart cart = (Cart)Session["cart"];
            if (cart==null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            cart.AddToCart(product,1);
            return RedirectToAction("Index",cart);
        }

        public RedirectToRouteResult RemoveFromCart(int productId)
         {
            Product product = _productService.Get(productId);

            Cart cart = (Cart)Session["cart"];
            if (cart==null)
            {
                cart=new Cart();
                Session["cart"] = cart;
            }
            cart.RemoveFromCart(product);

            return RedirectToAction("Index",cart);
        }

        public ActionResult Index()
        {
            var cart = Session["cart"];
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
            else
            {
                return View(shippingDetails);
            }
        }
    }
}