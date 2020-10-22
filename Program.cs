using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum int,int: " + Numeric8.Sum(3, 2));
            Console.WriteLine("Sum string,string: " + Numeric8.Sum("2", "3"));
            Console.WriteLine("Sun string,int: " + Numeric8.Sum("5", 6));
            Console.WriteLine("Sum int,string: " + Numeric8.Sum(3, "6"));
            Console.WriteLine("Sub int,int: " + Numeric8.Sub(3, 2));
            Console.WriteLine("Sub string,string: " + Numeric8.Sub("2", "3"));
            Console.WriteLine("Sub string,int: " + Numeric8.Sub("5", 6));
            Console.WriteLine("Sub int,string: " + Numeric8.Sub(3, "6"));
            Console.WriteLine("Or int,int: " + Numeric8.Or(3, 2));
            Console.WriteLine("Or string,string: " + Numeric8.Or("2", "3"));
            Console.WriteLine("Or string,int: " + Numeric8.Or("5", 6));
            Console.WriteLine("Or int,string: " + Numeric8.Or(3, "6"));
            Console.WriteLine("And int,int: " + Numeric8.And(3, 2));
            Console.WriteLine("And string,string: " + Numeric8.And("2", "3"));
            Console.WriteLine("And string,int: " + Numeric8.And("5", 6));
            Console.WriteLine("And int,string: " + Numeric8.And(3, "6"));
        }
    }
}
