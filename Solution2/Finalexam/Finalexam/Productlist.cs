using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalexam
{
	internal class Productlist
	{
		public List<Product> list;

        public Productlist()
        {
            list = new List<Product>();
        }
       
        //Thêm sản phẩm
        public void Addproduct()
        {
            //Nhậo số lượng sản phẩm muốn st
            Console.WriteLine("Nhap san pham");
            string Continue = "Y";
            do
            {
                Product product = new Product();
                product.Input();
                list.Add(product);
                Console.WriteLine("Continue? (Y/N):");
                Continue = Console.ReadLine();
            }
            while (Continue == "Y" || Continue = "y");
        }

        //Hiển thị danh sách sản phẩm
        public void Displayproduct()
        {
            Console.WriteLine("ProductID     Product Name     Price");
            foreach (Product product in list)
                product.Display();
        }

        //Tim san pham theo ID
        public int IndexOf(string id)
        {
            for (int i=0; i<list.Count<; i++)
            {
                if (list[i].ProductID == id)
                {
                    //Neu tim thay id san pham trong list
                    return i;
                }
            }
            //Neu khong tim thay
            return -1;
        }

        //Xoá sản phẩm qua ID sản 
        public void DeleteProduct()
        {
            string id;
            Console.Write("Nhap ID san pham muon xoa:");
            id = Console.ReadLine();
            // kiểm tra vị trí của id xem có trong mảng danh sach hay khôn
            int index = IndexOf(id);
            if(index < 0)
            {
                Console.WriteLine("Khong tim thay ID san pham")
            }
            else
            {
                list.RemoveAt(index);
                Console.WriteLine("San pham {0} da duoc xoa thanh cong", id);
            }
        }
    }
}

