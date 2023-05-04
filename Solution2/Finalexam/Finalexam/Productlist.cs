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
        //Thêm sản phẩm
        public void Addproduct()
        {
            //Nhậo số lượng sản phẩm muốn 
            do
            {
                Console.WriteLine("Enter number of product:");
                n = int.Parse(Console.ReadLine());
            }
            while (1>n || n > list.Length);

            for(int i=0, i < n, i++)
            {
                Console.WriteLine("Product no {0}", i + 1);
                list[i] = new Product();
                list[i].Input();
            }
        }
        //Hiển thị danh sách sản phẩm
       public void Displayproduct()
        {
            if(n <= 0)
            {
                Console.WriteLine("Have no product on list");
            }
            else
            {
                Console.WriteLine("List of product");
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("Student no {0}", i+1);
                    list[i].Display();
                }
            }
        }
        //Xoá sản phẩm qua ID sản phẩm
        public void DeleteProduct()
        {
           
        }
    }
}

