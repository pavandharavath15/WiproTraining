using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class MultiDelegate
    {
        #region delegate_declaration
        public delegate void MyDelegate(int num);
        #endregion 
        public static void Reverse(int num)
        {
            int revesred = 0;
            while (num > 0)
            {
                int rem = num % 10;
                revesred = (revesred * 10) + rem;
                num /= 10;
                
            }
            Console.WriteLine("Reversed number  is "+ revesred);
            
        }
        public static void PosNeg(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine("Positive Number...");
            }
            else
            {
                Console.WriteLine("Negative Number...");
            }
        }

        public static void EvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number...");
            }
            else
            {
                Console.WriteLine("Odd Number...");
            }
        }
        #region main_method
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter you number ");
            num=Convert.ToInt32(Console.ReadLine());

            MyDelegate obj = new MyDelegate(Reverse);

            obj += new MyDelegate(PosNeg);
            obj += new MyDelegate(EvenOdd);
            obj(num);
        }
        #endregion 

    }

}