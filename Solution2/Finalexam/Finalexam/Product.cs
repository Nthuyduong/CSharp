using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalexam
{
	internal class Product
	{
		public string ProductID;
		public string Name;
		public double Price;

		public Product()
		{
		}

		public Product(string ProductID, string Name, double Price)
		{
			this.ProductID = ProductID;
			this.Name = Name;
			this.Price = Price;
		}

		public void Input()
		{
			Console.WriteLine("Enter product ID:");
			ProductID = Console.ReadLine();
            Console.WriteLine("Enter product's name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter product's price:");
            Price = double.Parse(Console.ReadLine());
        }

		public void Display()
		{
			Console.WriteLine("ProducID: {0}, Name: {1}, Price: {2}", ProductID, Name, Price);
		}
	}
}

