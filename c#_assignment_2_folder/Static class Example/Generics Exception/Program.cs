using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    // This is for static class just to test that we can not create an object of it,
    // for the execution of its static methods.
    // Kindly note that only a static class can be invoked the static methods by using classname.
    // examples are as below
    static class Program
    {
        public static void Greeting()
        {
            Console.WriteLine("Thanks for checking this assignment");
        }

        

        static void Main(string[] args)
        {
            Program .Greeting();
            //here without making a object of the class we can directly invoked our static methods 
            //using Program.Greeting();

        }
    }
}

