using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CSharp
{
	public class Book : Product
	{
		public Book()
		{

		}

		public Book(string ProductID, string ProductName, int Price)
			:base(ProductID, ProductName, Price)
		{

		}

        public override double computeTax()
        {
			return Price * 5 / 100;
        }
    }
}

