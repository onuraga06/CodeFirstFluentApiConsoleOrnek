using CodeFirstFluentApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApiInvalidOperationException
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext northwind = new NorthwindContext();
            foreach (var item in northwind.Customers)
            {
                Console.WriteLine(item.ContactName);
            }
          
            Console.ReadLine();
        }
    }
}
