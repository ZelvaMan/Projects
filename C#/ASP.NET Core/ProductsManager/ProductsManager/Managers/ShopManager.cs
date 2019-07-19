using System;
using System.Collections.Generic;
using System.Linq;
using ProductsManager.Models;

namespace ProductsManager.Managers
{
	public class ShopManager
	{
		private OrderItemManager orderItemManager;
		private ProductManager productManager;
		private UserManager userManager;
		private OrderManager orderManager;

		public List<Product> Products
		{
			get { return productManager.Products; }
		}
		public List<OrderItem> Cart
		{
			get { return orderItemManager.OrderItems; }
		}
		public List<User> Users
		{
			get { return userManager.Users; }
		}

		public ShopManager(OrderItemManager orderItemManager, ProductManager productManager, UserManager userManager, OrderManager orderManager)
		{
			this.orderItemManager = orderItemManager;
			this.orderManager = orderManager;
			this.productManager = productManager;
			this.userManager = userManager;
		}


		public void AddToCart(int productId, int quantity)
		{

			Product product = productManager.FindProductById(productId);
			if (quantity <= product.InStock)
			{
				if (product.ProductAvailability == Availability.Avalible)
				{
					//productManager.ChangeStock(productId, -quantity);
					orderManager.AddOrderItem(productId, product.Price, quantity);
					productManager.SetAvailability(Availability.InCart,productId);
				}

				orderManager.changeQuantity(productId, quantity);
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(quantity), "not enough products in stock");
			}
		}

		public void Buy()
		{
			foreach (OrderItem ord in orderManager.OrderItems)
			{
				productManager.ChangeStock(ord.ProductID, -ord.Quantity);
				
			}
			orderManager.RemoveAll();
		}
		public Product FindProductById(int productId)
		{
			return productManager.FindProductById(productId);
		}

		public void DeleteOrder(int orderId)
		{
			OrderItem orderToDelete = orderManager.FindOrderItemByOrderId(orderId);
			orderManager.RemoveOrderItem(orderToDelete);
		}

		public void DeleteProduct(int productId)
		{
			productManager.RemoveProduct(productId);
			orderManager.RemoveOrderItem(orderManager.FindOrderItemByProductId(productId));
		}

	}
}