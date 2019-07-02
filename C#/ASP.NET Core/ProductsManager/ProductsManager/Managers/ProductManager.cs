using System;
using System.Collections.Generic;
using System.Linq;
using ProductsManager.Models;

namespace ProductsManager.Managers
{
	public class ProductManager
	{
		private readonly ApplicationState state;

		public ProductManager(ApplicationState state)
		{
			this.state = state;
			Load("");
		}

		public List<Product> Products
		{
			get
			{
				return state.Products;
			}
		}

		/// <summary>
		/// load Products from JSON file
		/// </summary>
		/// <param name="path"></param>
		public void Load(string path)
		{
			//load products from JSON file
			if (state.Products.Count == 0)
			{

				AddProduct("product1", 101, 2);
				AddProduct("product2", 102, 4);
				AddProduct("product3", 103, 6);
				AddProduct("product4", 104, 8);
				AddProduct("product5", 105, 10);
				AddProduct("product6", 106, 12);
				AddProduct("product7", 107, 14);
				AddProduct("product8", 108, 16);
				AddProduct("product9", 109, 18);
				AddProduct("product10", 110, 20);

			}
			Order();
		}

		/// <summary>
		/// order products in <see cref="Products"/> 
		/// </summary>
		public void Order()
		{
			state.Products = state.Products.OrderBy((product => product.ID)).ToList();
		}

		public void AddProduct(string name, int price, int inStock)
		{
			int id = state.LastProductId++;
			state.Products.Add(new Product() { ID = id, InStock = inStock, Name = name, Price = price });
			Order();
		}

		public void RemoveProduct(int productId)
		{
			state.Products.Remove(state.Products.Find((product => product.ID == productId)));
		}

		public Product FindProductById(int productId)
		{
			try
			{
				return state.Products.Find((product => product.ID == productId));
			}
			catch (Exception ex)
			{
				throw new ArgumentOutOfRangeException(nameof(productId), $"Could not find product with Id:{ productId }");
			}
		}

		public void ChangeStock(int productId, int quantity)
		{
			FindProductById(productId).InStock += quantity;
		}
	}
}