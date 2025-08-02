using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class MultiCastExam4
    {
        public delegate void DotnetFsd();

        public static void Project()
        {
            Console.WriteLine("Capstone Project to be done Last Phase...");
        }

        public static void MileStone1()
        {
            Console.WriteLine("MileStone 1 to be Conducted on Core Topics...");
        }

        public static void MileStone2()
        {
            Console.WriteLine("MileStone 2 to be on Dotnet Core...");
        }

        

        static void Main()
        {
            DotnetFsd obj = new DotnetFsd(MileStone1);
            obj += MileStone2;
            //obj += MileStone3;
            //obj += MileStone4;
            obj += Project;

            obj();
        }
    }
}