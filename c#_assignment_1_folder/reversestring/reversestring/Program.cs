using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversestring
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("Enter the value of a string");
            s1 = Console.ReadLine();
            char[] mychar = s1.ToCharArray();


            Array.Reverse(mychar);
            Console.WriteLine(mychar);

        }
    }
}
