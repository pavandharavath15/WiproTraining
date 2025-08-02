using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// Programm to show whether you are eligible to vote or not
/// </summary>
namespace Demo2
{
    internal class vote
    {
        public void show(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Sorry, You are not Eligible");
            }

        }
        static void Main()
        {
            int age;
            Console.WriteLine("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            vote vote = new vote();
            vote.show(age);

        }
    }
}
