using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Animal
{
    public double weight;
    public string name;

    public Animal(double weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine("Animal Name: " + this.name);
        Console.WriteLine("Animal Weight: " + this.weight + " pounds");
    }
}
