using System;

namespace Calci_NET_CORE_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string str;
            Console.WriteLine("Enter the value of two numbers are as:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operations you want to perform: Sum or Substract");
            str = Console.ReadLine();

            if (str == "Sum")
            {
                int sum = a + b;
                Console.WriteLine("Sum of two number is" + sum);
            }
            else if (str == "Substract")
            {
                int subs = a - b;
                Console.WriteLine("Sum of two number is" + subs);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
