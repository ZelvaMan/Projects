using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManager.Models
{
	public class ApplicationState
	{
		public List<Product> Products { get; set; } = new List<Product>();

		public List<Order> Orders { get; set; } = new List<Order>();

		public int LastProductId { get; set; }
		public int LastOrderId { get; set; }

		public ApplicationState()
		{
		}

	}
}
