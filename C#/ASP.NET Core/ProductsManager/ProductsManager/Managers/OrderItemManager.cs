using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProductsManager.Models;

namespace ProductsManager.Managers
{
	public class OrderItemManager
	{
		private ApplicationState state;

		public OrderItemManager(ApplicationState state)
		{
			this.state = state;
		}

		public List<OrderItem> OrderItems
		{
			get { return state.Cart; }
		}

		#region Removing

		public void RemoveOrderItem(OrderItem order)
		{
			state.Cart.Remove(order);
		}

		public void RemoveOrderItems(List<OrderItem> orders)
		{
			foreach (var order in orders)
			{
				RemoveOrderItem(order);
			}
		}

		public void RemoveAll()
		{
			state.Cart = new List<OrderItem>();
		}
		#endregion

		#region Finding

		public OrderItem FindOrderItemByProductId(int productId)
		{
			try
			{
				return state.Cart.Find((order => order.ProductID == productId));
			}
			catch (Exception ex)
			{
				throw new ArgumentOutOfRangeException(nameof(productId),$"Could not find orders with Id:{productId}");
			}
		}

		public OrderItem FindOrderItemByOrderId(int OrderId)
		{
			return state.Cart.Find((order => order.OrderId == OrderId));
		}

		#endregion

		public void AddOrderItem( int productId, int price, int quantity)
		{
			int id = state.LastProductId++;
			state.Cart.Add(new OrderItem() { OrderId = id, TotalPrice = price * quantity,  ProductID = productId, Quantity = quantity});
		}

		public void changeQuantity(int productId, int newQuantity)
		{
		OrderItem ord=	FindOrderItemByProductId(productId);
		ord.Quantity = newQuantity;
		}
	}
}