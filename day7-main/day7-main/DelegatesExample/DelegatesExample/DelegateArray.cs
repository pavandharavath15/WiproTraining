using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class DelegateArray
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
            Console.WriteLine("Reversed number  is " + revesred);

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
        static void Main()
        {
            Console.WriteLine("enter your number :");
            int num;
            num=Convert.ToInt32(Console.ReadLine());

            MyDelegate[] delarr =
            {
                new MyDelegate(Reverse),
                new MyDelegate(PosNeg),
                new MyDelegate(EvenOdd)
            };
            foreach(MyDelegate del in delarr)
            {
                del(num);
            }
        }
    }
}
