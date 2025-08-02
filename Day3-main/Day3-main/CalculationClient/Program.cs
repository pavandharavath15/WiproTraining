using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLIbrary;
namespace CalculationClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation obj = new Calculation();
            int a, b;
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj.Sum(a, b));
            Console.WriteLine(obj.Sub(a, b));
            Console.WriteLine(obj.Mul(a,b));
        }
    }
}
