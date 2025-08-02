using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class Delegateex2
    {
        public delegate void MyDelegate(string s);

        public static void Display(string s)
        {
            Console.WriteLine("welcome to delegate series "+s);
        }
        static void Main()
        {
            MyDelegate obj=new MyDelegate(Display);
            Console.WriteLine("Enter your  name:");
            string name=Console.ReadLine();

            obj(name);
        }
    }
}
