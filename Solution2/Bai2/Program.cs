//Viết chương trình tính giai thừa của một số nguyên dương N nhập từ bàn phím.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Nhap so nguyen n");
        n = int.Parse(Console.ReadLine());
        int giaithua = 1;

        if(n==0 || n==1)
        {
            giaithua = 1;
        }
        else
        {

            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }
        }
        Console.WriteLine("Giai thừa của {0} là {1}", n, giaithua);
    }
}

