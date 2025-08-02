using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class calcu
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("enter the number1");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number2");
            b=Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum is " + c);
        }
    }
}
