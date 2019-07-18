using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsManager.Managers;
using ProductsManager.Models;

namespace ProductsManager.Controlers
{
	public class HomeController : Controller
	{
		private ShopManager manager;

		public HomeController(ShopManager manager)
		{
			this.manager = manager;
		}

		public ActionResult Index()
		{
			return RedirectToAction(nameof(ShowProducts));
		}

		#region Products

		[HttpGet("Product")]
		public ActionResult ShowProducts()
		{
			List<Product> products;
			if ((products = manager.Products) != null)
			{
				ViewBag.data = products;
			}

			return View();
		}

		[HttpGet("Product/{productId}")]
		public ActionResult ShowBuyProduct(int productId)
		{
			ViewBag.Product = manager.FindProductById(productId);
			return View();
		}

		//[HttpPost("Product/buy/{productId}")]

		[HttpPost("Product/{productId}")]
		public ActionResult AddToCart(int productId, int quantity)
		{
			manager.AddToCart(productId, quantity);
			return RedirectToAction(nameof(ShowProducts));

		}

		[HttpGet("Product/remove/{productId}")]
		public ActionResult RemoveProduct(int productId)
		{
			manager.DeleteProduct(productId);
			return RedirectToAction(nameof(ShowProducts));
		}

		#endregion

		#region Cart

		[HttpGet("cart/delete/{id}")]
		public ActionResult DeleteOrder(int id)
		{
			manager.DeleteOrder(id);
			return RedirectToAction(nameof(ShowOrders));
		}

		[HttpGet("cart")]
		public ActionResult ShowOrders()
		{
			ViewBag.Orders = manager.Orders;
			return View();
		}

		[HttpPost("cart/buyall")]
		public ActionResult Buy()
		{
			manager.Buy();
			return RedirectToAction(nameof(ShowProducts));
		}
			#endregion

		[HttpGet("users")]
		public ActionResult ShowUsers()
		{
			ViewBag.Users = manager.Users;
			return View();
		}
	}
}