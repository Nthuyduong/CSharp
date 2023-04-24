//Viết chương trình nhập vào một số nguyên dương, in ra màn hình kết quả thông báo số đó có phải là số nguyên tố hay không? (Số nguyên tố là số chỉ chia hết cho 1 và chính nó)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Nhap so nguyen n");
        n = int.Parse(Console.ReadLine());
        int dem = 0;

        bool isPrime = true;

        if (n < 2)
        {
            Console.WriteLine("n khong phai so nguyen to");
        }
        for(int i =2; i<= Math.Sqrt(n); i++)
         {
             if(n%i==0)
              {
                  dem++;
              }
        }
        if (dem == 0)
        {
            Console.WriteLine("{0} la nguyen to",n);
        }
        else
        {
            Console.WriteLine("{0} khong phai nguyen to", n);
        }
    }
}

