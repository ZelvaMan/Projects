using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingletonAspNet.Models;

namespace SingletonAspNet.Controlers
{
	
	public class HomeController : Controller
	{
		Singleton singl = new Singleton();
		[HttpGet()]
		public ActionResult Index()
		{
			ViewBag.Number = singl.Number;
			return View();
		}

		[HttpPost]
		public ActionResult Default()
		{
			singl.IncreaseNumber();
			return RedirectToAction("Index");
		}

		public HomeController(Singleton singleton)
		{
			singl = singleton;
		}
	}
}