using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Tiger : Animal
    {
        public Tiger(double weight, string name)
        {
            base.Animal(weight, name);
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("I am a Tiger.");
        }
    }
}

