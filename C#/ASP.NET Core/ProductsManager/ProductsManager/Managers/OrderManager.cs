using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProductsManager.Models;

namespace ProductsManager.Managers
{
	public class OrderManager
	{
		private ApplicationState state;

		public OrderManager(ApplicationState state)
		{
			this.state = state;
		}

		public List<Order> Orders
		{
			get { return state.Orders; }
		}

		#region Removing

		public void RemoveOrder(Order order)
		{
			state.Orders.Remove(order);
		}

		public void RemoveOrders(List<Order> orders)
		{
			foreach (var order in orders)
			{
				RemoveOrder(order);
			}
		}
		

		#endregion

		#region Finding

		public List<Order> FindOrdersByProductId(int productId)
		{
			try
			{
				return state.Orders.FindAll((order => order.ProductID == productId));
			}
			catch (Exception ex)
			{
				throw new ArgumentOutOfRangeException(nameof(productId),$"Could not find orders with Id:{productId}");
			}
		}

		public Order FindOrderByOrderId(int OrderId)
		{
			return state.Orders.Find((order => order.OrderId == OrderId));
		}

		#endregion

		public void AddOrder( int productId, int price, int quantity)
		{
			int id = state.LastProductId++;
			state.Orders.Add(new Order() { OrderId = id, TotalPrice = price,  ProductID = productId, Quantity = quantity});
		}
	}
}