using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsManager.Models;

namespace ProductsManager.Controlers
{
	public class HomeController : Controller
	{
		private ProductCollections Database;
		public ActionResult Index()
		{
			return RedirectToAction("ShowProducts");
		}

		[HttpGet("Product")]
		public ActionResult ShowProducts()
		{
			ViewBag.data = Database.Products;
			return View();
		}

		[HttpGet("Product/{ID}")]
		public ActionResult ShowBuyProduct(int ID)
		{
			Product product = Database.Products.Find((p => p.ID == ID));
			if (product == null)
			{
				return Content("Product not found");
			}

			ViewBag.Product = product;
			return View();
		}

		//[HttpPost("Product/buy/{ID}")]
		[HttpPost("Product/{ID}")]
		public ActionResult BuyProducts(int ID, int quantity)
		{
			Database.Buy(ID,quantity);
			return RedirectToAction("ShowProducts");

		}

		[HttpGet("Order")]
		public ActionResult ShowOrders()
		{
			ViewBag.Orders = Database.Orders;
			return View();
		}
		public HomeController(ProductCollections productCollections)
		{
			Database = productCollections;
		}
	}
}