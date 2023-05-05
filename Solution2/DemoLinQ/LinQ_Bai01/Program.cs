using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo tập dữ liệu
            string[] data = { "To", "ve", "hon", "nguoi", "thi", "nguoi", "se",
            "tro", "thanh", "ke", "thu", "cua", "ta", "Chiu", "nhuong", "nguoi",
            "thi", "nguoi", "se", "la", "ban", "cua", "ta" };
            //truy vấn dữ liệu
            IEnumerable<string> result1 = from d in data select d;
            //hiển thị kết quả
            Console.WriteLine("Hien thi tat ca ket qua");
            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }
            //truy vấn theo điều kiện lấy các từ là "nguoi"
            IEnumerable<string> result2 = from d in data
                                          where d.Equals("nguoi")
                                          select d;
            //hiển thị kết quả
            Console.WriteLine("\nTruy van theo dieu kien");
            foreach (var item in result2)
            {
                Console.WriteLine(item + " ");
            }
            //sắp xếp dữ liệu
            IEnumerable<string> result3 = from d in data orderby d select d; 
            //hiển thị kết quả
            Console.WriteLine("Hien thi tat ca ket qua sap xep");
            foreach (var item in result3)
            {
                Console.Write(item + " ");
            }
            //Lấy tập dữ liệu mới
            
            var result4 = from d in data
                          select new {Thuong = d.ToLower(),Hoa =d.ToUpper()};
            //hiển thị kết quả
            Console.WriteLine("Chu thuong va hoa");
            foreach (var item in result4)
            {
                Console.WriteLine(item.Thuong + ":" + item.Hoa);
            }
        }
    }
}
