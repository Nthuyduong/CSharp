using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CSharp;
public abstract class Product
{
    public string ProductID;
    public string ProductName;
    public double Price;

    public Product()
    {

    }

    public Product(string ProductID, string ProductName, int Price)
    {
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
    }

    //abstract method to calculate tax of product.
    public abstract double computeTax();
}

