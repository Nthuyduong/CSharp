using System;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Threading;

namespace Exam_CSharp
{
    public class Demo
    {
        

        public static void Main(string[] args)
        {
            double totalTaxofBook = 0;
            double totalTaxofPhone = 0;
            //create Product array of size 5(three Books and two Phones)
            Product[] list = new Product[5];

            list[1] = new Book("no1", "The sun", 70 );
            list[2] = new Book("no2", "Harry Potter", 50);
            list[3] = new Book("no3", "Little woman", 80);
            list[4] = new Phone("no4", "Iphone", 500);
            list[5] = new Phone("no5", "Sam sung", 300);

            foreach(Product product in list)
            {
                if(product is Book)
                {
                    totalTaxofBook += product.computeTax();
                }
                else if(product is Phone)
                {
                    totalTaxofPhone += product.computeTax();
                }
            }

            //Displaying result
            Console.WriteLine("Total Tax of book is: {0}",  totalTaxofBook);
            Console.WriteLine("Total Tax of Phone is: {0}", totalTaxofPhone);
        }
    }
}
