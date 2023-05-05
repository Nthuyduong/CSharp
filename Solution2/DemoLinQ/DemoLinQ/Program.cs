using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQ
{
    //Định nghĩa lớp
    class Customer
    {
        public string Name { get; set; }
        public string PCode { get; set; }//mã tỉnh
    }
    class Province
    {
        public string PCode { get; set; } //mã tỉnh
        public string PName { get; set; }//tên tỉnh
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo Customer.
            var customers = new Customer[]
            {
                new Customer { Name = "Sam", PCode = "04"},
                new Customer { Name = "Dave", PCode = "08" },
                new Customer { Name = "Julia", PCode = "034" },
                new Customer { Name = "Sue", PCode = "04" }
            };
            //Khởi tạo Province.
            var provinces = new Province[]
            {
                new Province{PCode = "04", PName = "Ha Noi"},
                new Province{PCode = "08", PName = "Ho Chi Minh City"},
                new Province{PCode = "034", PName = "Hai Duong"},
                new Province{PCode = "016", PName = "Hai Phong"}
            };
            //Sử dụng truy vấn và join 2 tập dữ liệu dựa trên PCode.
            var query = from c in customers
                        join p in provinces on c.PCode equals p.PCode
                        select new { c.Name, p.PName };
            //Hiển thị tên khách hàng và tên tỉnh.
            foreach (var cust_pro in query)
            {
                Console.WriteLine("{0} from {1}", cust_pro.Name, cust_pro.PName);
            }

        }
    }
}
