using System;
using System.Collections.Generic;
using ProductsManager.Models;

namespace ProductsManager.Managers
{
	public class ShopManager
	{
		private OrderManager orderManager;
		private ProductManager productManager;

		public List<Product> Products
		{
			get { return productManager.Products; }
		}
		public List<Order> Orders
		{
			get { return orderManager.Orders; }
		}

		public ShopManager(OrderManager orderManager, ProductManager productManager)
		{
			this.orderManager = orderManager;
			this.productManager = productManager;
		}


		public void Buy(int productId, int quantity)
		{
			Product product = productManager.FindProductById(productId);
			if (quantity <= product.InStock)
			{
				productManager.ChangeStock(productId, -quantity);
				orderManager.AddOrder(productId, product.Price * quantity, quantity);
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(quantity), "not enough products in stock");
			}
		}

		public Product FindProductById(int productId)
		{
			return productManager.FindProductById(productId);
		}
	}
}