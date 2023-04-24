namespace exam;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cylinder
{
    public double radius;
    public double height;
    public double baseArea;
    public double lateralArea;
    public double totalArea;
    public double volume;

    public Cylinder()
    {

    }

    public Cylinder(double radius, double height, double baseArea,double lateralArea, double totalArea, double volume)
    {
        this.radius = radius;
        this.height = height;
        this.baseArea = baseArea;
        this.lateralArea = lateralArea;
        this.totalArea = totalArea;
        this.volume = volume;
    }

    public void Input()
    {
        Console.WriteLine("Enter radius");
        this.radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        this.height = double.Parse(Console.ReadLine());
    }

     public void Process()
    {
        this.baseArea = 3.14 * (this.radius * this.radius);
        this.lateralArea = 2 * 3.14 * this.radius * this.height;
        this.totalArea = (2 * this.baseArea) + this.lateralArea;
        this.volume = this.baseArea * this.height;

      }

    public string Result()
     {
        string result = "Base Area: " + this.baseArea + "\n";
        result += "Lateral Area: " + this.lateralArea + "\n";
        result += "Total Area: " + this.totalArea + "\n";
        result += "Volume: " + this.volume + "\n";
        return result;
    }
    
}

