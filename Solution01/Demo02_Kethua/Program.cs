using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Kethua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentA = new Student("Hoa", 20,9.5);
            studentA.display();//gọi display() của Student

            Student studentB = new Student();
            Console.WriteLine("Student B");
            studentB.input();//gọi input() của Student
            studentB.display();//gọi display() của Student

            //có thể sử dụng biến tham chiếu kiểu lớp cha
            //cho biến đó tham chiếu đến đối tượng của lớp con
            Person personC = new Student();
            Console.WriteLine("Student C");
            
            personC.input();
            //vẫn gọi input của lớp con Student (override) đã ghi đè lên input của lớp cha
            
            personC.display();
            //gọi display của lớp cha Person do display() ở Student sử dụng new (tạo bản sao riêng)
            
            Console.ReadKey();
        }

    }
}
