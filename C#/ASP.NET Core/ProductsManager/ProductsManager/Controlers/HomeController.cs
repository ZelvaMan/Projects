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
			return RedirectToAction("ShowProducts");
		}

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
		public ActionResult BuyProducts(int productId, int quantity)
		{
			manager.Buy(productId, quantity);
			return RedirectToAction("ShowProducts");

		}

		[HttpGet("Order")]
		public ActionResult ShowOrders()
		{
			ViewBag.Orders = manager.Orders;
			return View();
		}

		
	}
}