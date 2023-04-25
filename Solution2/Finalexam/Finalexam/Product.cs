using System;
namespace Finalexam
{
	public class Product
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

		public void Add()
		{
			Console.WriteLine("Enter product ID:");
			ProductID = Console.ReadLine();
            Console.WriteLine("Enter product's name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter product's price:");
            Price = double.Parse(Console.ReadLine());
        }
	}
}

