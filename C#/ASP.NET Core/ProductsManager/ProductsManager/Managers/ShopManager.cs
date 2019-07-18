using System;
using System.Collections.Generic;
using ProductsManager.Models;

namespace ProductsManager.Managers
{
	public class ShopManager
	{
		private OrderManager orderManager;
		private ProductManager productManager;
		private UserManager userManager;

		public List<Product> Products
		{
			get { return productManager.Products; }
		}
		public List<Order> Orders
		{
			get { return orderManager.Orders; }
		}
		public List<User> Users
		{
			get { return userManager.Users; }
		}

		public ShopManager(OrderManager orderManager, ProductManager productManager, UserManager userManager)
		{
			this.orderManager = orderManager;
			this.productManager = productManager;
			this.userManager = userManager;
		}


		public void AddToCart(int productId, int quantity)
		{
			Product product = productManager.FindProductById(productId);
			if (quantity <= product.InStock)
			{
				//productManager.ChangeStock(productId, -quantity);
				orderManager.AddOrder(productId, product.Price * quantity, quantity);
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(quantity), "not enough products in stock");
			}
		}

		public void Buy()
		{
			foreach (Order ord in orderManager.Orders)
			{
				productManager.ChangeStock(ord.ProductID, -ord.Quantity);
			}
			orderManager.RemoveAll();
		}
		public Product FindProductById(int productId)
		{
			return productManager.FindProductById(productId);
		}

		public void DeleteOrder( int orderId )
		{
			Order orderToDelete = orderManager.FindOrderByOrderId(orderId);
			orderManager.RemoveOrder(orderToDelete);
		}

		public void DeleteProduct(int productId)
		{
			productManager.RemoveProduct(productId);
			orderManager.RemoveOrders(orderManager.FindOrdersByProductId(productId));
		}
	}
}