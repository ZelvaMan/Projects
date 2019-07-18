using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManager.Models
{
	public class Order
	{
		public List<Order> OrderItems { get; set; }

		public int TotalPrice
		{
			get
			{
				int price = 0;
				foreach (Order item in OrderItems)
				{
					price += item.TotalPrice;
				}

				return price;
			}
		}
	}
}
