using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FileProvider;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileViewer.Controlers
{
	public class HomeController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return  Redirect("/files");
		}

		[HttpGet("files")]
		public IActionResult FileList([FromQuery]string path)
		{
			if (path == null)
			{
				ViewBag.Files = DirectoryProvider.GetDrives();
			}
			else
			{
				ViewBag.Parent = DirectoryProvider.GetParentPath(path);
				ViewBag.Files = DirectoryProvider.GetFilesInDirectory(path);
			}

			return View();
		}

		[HttpGet("files/info")]
		public IActionResult FileInfo([FromQuery] string path)
		{
			if (path == null)
				return StatusCode(400);
			//get infos about file
			ViewBag.Info = DirectoryProvider.GetFileInfo(path);

			return View();
		}
	}
}
