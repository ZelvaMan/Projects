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

		public List<Order> Orders
		{
			get { return orderManager.OrdersWithoutCanceled; }
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
					orderItemManager.AddOrderItem(productId, product.Price, quantity);
					productManager.SetAvailability(Availability.InCart,productId);
				}

				orderItemManager.changeQuantity(productId, quantity);
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(quantity), "not enough products in stock");
			}
		}

		public void Buy()
		{
			foreach (OrderItem ord in orderItemManager.OrderItems)
			{
				productManager.ChangeStock(ord.ProductID, -ord.Quantity);
				
			}
			orderManager.AddOrder(orderItemManager.OrderItems);
			orderItemManager.RemoveAll();
		}

		public Product FindProductById(int productId)
		{
			return productManager.FindProductById(productId);
		}

		public void DeleteOrder(int orderId)
		{
			OrderItem orderToDelete = orderItemManager.FindOrderItemByOrderId(orderId);
			orderItemManager.RemoveOrderItem(orderToDelete);
		}

		public void DeleteProduct(int productId)
		{
			productManager.RemoveProduct(productId);
			orderItemManager.RemoveOrderItem(orderItemManager.FindOrderItemByProductId(productId));
		}

		public Order FindOrderByOrderId(int orderId)
		{
			return orderManager.FindOrderByOrderId(orderId);
		}
	}
}