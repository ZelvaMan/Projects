using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManager.Models
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

			Order();
		}

		/// <summary>
		/// load Products from JSON file
		/// </summary>
		/// <param name="path"></param>
		public void Load(string path)
		{
			//load products from JSON file

			Products.Add(new Product() { InStock = 2, Price = 100, ID = 1, Name = "one" });
			Products.Add(new Product() { InStock = 2, Price = 100, ID = 2, Name = "one" });
			Products.Add(new Product() { InStock = 3, Price = 100, ID = 3, Name = "one" });
			Products.Add(new Product() { InStock = 2, Price = 100, ID = 4, Name = "one" });
			Products.Add(new Product() { InStock = 2, Price = 100, ID = 5, Name = "one" });
			Products.Add(new Product() { InStock = 6, Price = 100, ID = 6, Name = "one" });
			Products.Add(new Product() { InStock = 2, Price = 100, ID = 7, Name = "one" });
			Products.Add(new Product() { InStock = 8, Price = 100, ID = 8, Name = "one" });
			Products.Add(new Product() { InStock = 2, Price = 100, ID = 9, Name = "one" });

		}

		/// <summary>
		/// order products in <see cref="Products"/> 
		/// </summary>
		public void Order()
		{
			Products = Products.OrderBy((product => product.ID)).ToList();
		}
	}
}
