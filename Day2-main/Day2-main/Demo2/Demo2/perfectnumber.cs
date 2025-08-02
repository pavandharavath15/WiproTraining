using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class perfectnumber
    {
        public void perfect(int n) {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if(n%i==0)
                {
                    sum += i;
                }

            }
            if (sum == n)
            {
                Console.WriteLine(n + " is a perfect number");
            }
            else
            {
                Console.WriteLine(n + " is not a perfect number");
            }
        
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            perfectnumber obj= new perfectnumber();
            obj.perfect(n);

        }
    }
}
