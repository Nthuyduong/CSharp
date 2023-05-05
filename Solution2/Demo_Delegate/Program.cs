using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate
{
    //khai báo delegate đầu vào là 2 số int, đầu ra là số int
    public delegate int Calculation(int num1, int num2);
    internal class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            int a = 20, b = 10;
            //sử dụng delegate Calculation
            //tạo thể hiện của delegate truyền phương thức Sum
            Calculation cal = new Calculation(Sum);
            int sum = cal(a, b);//Sum(a,b)
            Console.WriteLine("sum = " + sum);
            //tạo thể hiện của delegate truyền phương thức Sub
            cal = new Calculation(Sub);
            int sub = cal(a, b);//Sub(a,b)
            Console.WriteLine("sub = " + sub);
            //tạo 1 đối tượng Calculation gán hàm Mul để thực hiện
            cal = new Calculation(Mul);
            int mul = cal(a, b); //Mul(a,b);
            Console.WriteLine("mul = " + mul);
            Console.ReadKey();
        }
    }
}
