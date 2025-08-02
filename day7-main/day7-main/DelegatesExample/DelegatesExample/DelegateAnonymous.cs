using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class DelegateAnonymous
    {
        public delegate void AnonyDelegate(string s);

        static void Main()
        {
            AnonyDelegate obj = delegate (string s)
            {
                Console.WriteLine("this is anonymous dele" + s);
            };
            obj("pavan");
        }


    }
}
