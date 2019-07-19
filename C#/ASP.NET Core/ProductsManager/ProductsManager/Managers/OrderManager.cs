using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsManager.Models;

namespace ProductsManager.Managers
{
	public class OrderManager
	{
		private ApplicationState state;

		public List<Order> OrdersWithoutCanceled
		{
			get
			{
				List<Order> orders = new List<Order>();
				foreach (Order order in OrdersWithCanceled)
				{
					if(order.OrderValidity == validity.Valid)
						orders.Add(order);
				}
			}
		}

		public List<Order> OrdersWithCanceled
		{
			get { return state.Orders; }
		}
		public OrderManager(ApplicationState state)
		{
			this.state = state;
		}

		public void AddOrder(List<OrderItem> Cart)
		{
			int id = state.LastOrderId++;
			state.Orders.Add(new Order(){orderId = id,OrderItems = Cart});
			
		}

		public void RemoveOrder(int orderId)
		{
			if (orderId <= state.LastOrderId)
			{
				state.Orders.Remove(state.Orders.Find((order => order.orderId == orderId)));
			}
		}

		public Order FindOrderByOrderId(int orderId)
		{
			return state.Orders.Find((order => order.orderId == orderId));
		}

		public void CancelOrder(int orderId)
		{
			OrdersWithCanceled.Find((order => order.orderId == orderId)).OrderValidity = validity.Canceled;
		}
	}
}
