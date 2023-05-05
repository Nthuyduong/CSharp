using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CSharp;
abstract class Product
{
    public string ProductID;
    public string ProductName;
    public int Price;

    public Product()
    {

    }

    public Product(string ProductID, string ProductName, int Price)
    {
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
    }

    public abstract double computeTax();
}

