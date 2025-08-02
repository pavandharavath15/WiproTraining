using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// delegetes is a reference type varaiable that which allows to pass function as variable
/// </summary>
namespace DelegatesExample
{
    internal class Delegates1
    {
        public delegate void MyDelegate();// declaration of delegate

        public static void Display()//here Display is the method name
        {
            Console.WriteLine("Welcome to my delegate 1 .");
        }

        static void Main()
        {
            MyDelegate delg=new MyDelegate(Display);

            delg();

        
        }

    }
}
