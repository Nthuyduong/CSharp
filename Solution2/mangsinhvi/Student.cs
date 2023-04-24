using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangsinhvi
{
	class Student
	{
		//Khai bao cac bien cua Student
		public string rollno;
		public string name;
		public float mark;

		////get set rollno
		//public string Rollno
		//{
		//	get => rollno;
		//	set => rollno = value;
		//}
		////get set name
		//public String Name
		//{
		//	get => name;
		//	set => name = value;
		//}
		////get set mark
		//public float Mark
		//{
		//	get => mark;
		//	set => mark = value;
		//}
		//Xay dung ham tao (constructor)
		//Ham tao khong tham so
		public Student()
		{
			rollno = "";
			name = "";
			mark = 8;
		}
		//Ham tao 
		public Student(String rollno, String name, float mark)
		{
			this.rollno = rollno;
			this.name = name;
			this.mark = mark;
		}
		//Xay dung phuong thuc nhap
        public void Input()
		{
			Console.WriteLine("Enter rollno:");
			rollno = Console.ReadLine();
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter mark:");
			mark = float.Parse(Console.ReadLine());
        }
		//Xay dung phuong thuc hien thi
		public void Display()
		{
			Console.WriteLine("Rollno: {0}, Name: {1}, Mark: {2}", rollno, name, mark); ;
		}
	}
}

