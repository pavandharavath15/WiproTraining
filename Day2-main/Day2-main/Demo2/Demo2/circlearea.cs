using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///
///  Program to find the area of the circle
/// </summary>
namespace Demo2
{
    
    internal class Circlearea
    {
        public void arecircl(double radius)
        {
            double circum, area;
            area = Math.PI * radius * radius;
            circum = 2 * Math.PI * radius;
            Console.WriteLine("Area of circle is " + area);
            Console.WriteLine("Circumference of circle is " + circum);


        }
        static void Main()
        {
            double radius;
            Console.WriteLine("Enter the Radius");
            radius=Convert.ToDouble(Console.ReadLine());
            Circlearea value = new Circlearea();
            value.arecircl(radius);

        }
    }
}
