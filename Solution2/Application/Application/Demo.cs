using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application;

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


