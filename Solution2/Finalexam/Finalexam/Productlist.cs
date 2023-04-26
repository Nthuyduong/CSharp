using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalexam
{
	public class Productlist
	{
		Product[] list;
        int n;

        public Productlist()
        {
            n = 0;
            list = new Product[10];
        }

        public void Addproduct()
        {
            do
            {
                Console.WriteLine("Enter number of product:");
                n = int.Parse(Console.ReadLine());
            }
            while (1>n || n > list.Length);

            for(int i=0, i < n, i++)
            {
                Console.WriteLine("Product no {0}", i);
                list[i] = new Product();
                list[i].Input();
            }
        }

       public void Displayproduct()
        {

        }
    }
}

