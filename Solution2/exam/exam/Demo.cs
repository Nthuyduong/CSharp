using System;
namespace exam
{
	public class Demo
	{
        public static void Main(string[] args)
        {
            Cylinder c = new Cylinder();
            c.Input();
            c.Process();
            Console.WriteLine(c.Result());
        }

    }
}

