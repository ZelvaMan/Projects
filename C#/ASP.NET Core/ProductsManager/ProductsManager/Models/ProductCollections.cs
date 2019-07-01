using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManager.Models
{
	public class ProductCollections
	{
		private List<Product> _products = new List<Product>();

		public List<Product> Products
		{
			get { return _products; }
			set { _products = value; }
		}

		public List<Order> Orders = new List<Order>();


		public ProductCollections()
		{
			Load("");
			Order();
		}

		/// <summary>
		/// load Products from JSON file
		/// </summary>
		/// <param name="path"></param>
		public void Load(string path)
		{
			//load products from JSON file
			if (Products.Count == 0)
			{

				Products.Add(new Product() { InStock = 2, Price = 100, ID = 1, Name = "product1" });
				Products.Add(new Product() { InStock = 4, Price = 100, ID = 2, Name = "product2" });
				Products.Add(new Product() { InStock = 6, Price = 100, ID = 3, Name = "product3" });
				Products.Add(new Product() { InStock = 8, Price = 100, ID = 4, Name = "product4" });
				Products.Add(new Product() { InStock = 10, Price = 100, ID = 5, Name = "product5" });
				Products.Add(new Product() { InStock = 12, Price = 100, ID = 6, Name = "product6" });
				Products.Add(new Product() { InStock = 14, Price = 100, ID = 7, Name = "product7" });
				Products.Add(new Product() { InStock = 16, Price = 100, ID = 8, Name = "product8" });
				Products.Add(new Product() { InStock = 18, Price = 100, ID = 9, Name = "product9" });
				Products.Add(new Product() { InStock = 20, Price = 100, ID = 10, Name = "product10" });

			}
		}

		/// <summary>
		/// order products in <see cref="Products"/> 
		/// </summary>
		public void Order()
		{
			Products = Products.OrderBy((product => product.ID)).ToList();
		}

		public void Buy(int productID, int quantity)

		{
			 int index = Products.FindIndex((product => product.ID == productID));
			 int price = Products[index].Price * quantity;
			Products[index].InStock -= quantity;
			if (Products[index].InStock <= 0)
				Products.RemoveAt(index);
			Orders.Add(new Order(){ID = productID, Quantity = quantity, TotalPrice = price});
		}
	}
}
