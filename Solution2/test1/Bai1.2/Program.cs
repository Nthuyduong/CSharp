//Viết chương trình cho phép người dùng nhập vào một số nguyên bất kỳ, khi nhập số 0 thì kết thúc và in ra số lớn nhất trong các số đã nhập.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Lap;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        int max = 0;

        do
        {
            Console.WriteLine("Nhap so nguyen n");
            i = int.Parse(Console.ReadLine());
            if (i > max)
            {
                max = i;
            }
        }
        while (i != 0);
        Console.WriteLine("Số lớn nhất đã nhập là: {0}", max);
    }
}