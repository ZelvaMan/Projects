using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;

namespace ProductManager.Controlers
{
	public class HomeController : Controller
	{
		private ProductCollections Database = new ProductCollections();
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
		public ActionResult BuyProducts(int ID, int Quantity)
		{
			int index = Database.Products.FindIndex((p => p.ID == ID));
			Product product = Database.Products[index];
			product.InStock -= Quantity;
			if (product.InStock <= 0)
				Database.Products.RemoveAt(index);
			else
				Database.Products[index] = product;

			return RedirectToAction("ShowProducts");

		}

		public HomeController()
		{
			Database.Load(" ");
		}
	}
}