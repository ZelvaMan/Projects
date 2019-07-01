using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManager.Models
{
	public class Product
	{
		public int ID { get;  set; }
		public string Name { get;  set; }
		public int Price { get; set; }
		public int InStock { get; set; }
	}

	public struct Order
	{
		public int ID { get; set; }
		public int Quantity { get; set; }
		public int TotalPrice { get; set; }

	}
}
