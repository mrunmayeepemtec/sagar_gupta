using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_netframework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine( "Enter the two number:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            string str;
            Console.WriteLine("Enter the operations such as sum, substract ");
            str = Console.ReadLine();

            if (str == "sum")
            {
                int add;
                add = a + b;
                Console.WriteLine("Sum of two number is:"+add);
            }
            if(str == "substract")
            {
                int substract;
                substract = a - b;
                Console.WriteLine("Substraction of the two number is"+substract);
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
