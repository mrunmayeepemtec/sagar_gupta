using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    internal class Program
    {
        public void compare(string s1,string s2)
        {
            if(String.Equals(s1,s2))
            {
                Console.WriteLine("{s1} and {s2} have same value");
            }
            else
                Console.WriteLine( "Strings are different");
        }
        static void Main(string[] args)
        {
            string s1,s2;
            Console.WriteLine("Enter the two value of string:");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            Program obj = new Program();
            obj.compare(s1,s2);
        }
    }
}
