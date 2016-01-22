using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Models;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApp.Controllers
{
    public class CartController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<CartItemModel> cartItems = null;
            if (HttpContext.Session.GetString("cartItems") != null)
            {
                cartItems = GetCartItemsFromSession();
            }
            return View(cartItems);
        }

        public JsonResult AddToCart(Guid id, int quantity)
        {
            var cartItem = new CartItemModel { AlbumId = id, Quantity = quantity };
            var cartItems = AddCartItem(cartItem);
            PutCartItemsInSession(cartItems);
            return Json(new { result="ok" });
        }

        private List<CartItemModel> AddCartItem(CartItemModel cartItem)
        {
            List<CartItemModel> cartItems = null;
            if (HttpContext.Session.GetString("cartItems") != null)
            {
                cartItems = GetCartItemsFromSession();
            }
            else
            {
                cartItems = new List<CartItemModel>();
            }
            cartItems.Add(cartItem);
            return cartItems;
        }

        private void PutCartItemsInSession(List<CartItemModel> cartItems)
        {
            var json = BusinessLogic.SerializationLogic<List<CartItemModel>>.Serialize(cartItems);
            HttpContext.Session.SetString("cartItems", json);
        }

        private List<CartItemModel> GetCartItemsFromSession()
        {
            var json = HttpContext.Session.GetString("cartItems");
            return BusinessLogic.SerializationLogic<List<CartItemModel>>.Deserialize(json);

        }
    }
}
