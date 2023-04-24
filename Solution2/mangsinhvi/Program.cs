using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangsinhvi
{
	public class Program
	{
        //Tao menu
		public static int Menu()
		{
            int Select;
			Console.WriteLine("----MENU----");
            Console.WriteLine("1: Enter student list");
            Console.WriteLine("2: Display student list");
            Console.WriteLine("3: Arrange Student by mark");
            Console.WriteLine("4: Find student by name");
            Console.WriteLine("Enter 1 - 4:");

            int v = int.Parse(Console.ReadLine());
            Select = v;
            return Select;
        }

        //
        public static void Main(string[] args)
        {
            Studentlist list = new Studentlist();
            int select;
            do
            {
                select = Menu();
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Enter student list");
                        list.AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("Enter student list");
                        list.DisplayStudent();
                        break;
                    case 3:
                        Console.WriteLine("Enter student list");
                        list.ArrangeStudent();
                        list.DisplayStudent();
                        break;
                    case 4:
                        Console.WriteLine("Enter student list");
                        list.SearchStudent();
                        break;
                    default:
                        Console.WriteLine("End");
                        break;
                }
              
            } while (select>=1&&select<=4);
        }
	}
}

