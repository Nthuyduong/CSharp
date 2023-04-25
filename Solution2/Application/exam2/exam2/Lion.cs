using System;
namespace exam2
{
    class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("I am a Lion.");
        }
    }
}

