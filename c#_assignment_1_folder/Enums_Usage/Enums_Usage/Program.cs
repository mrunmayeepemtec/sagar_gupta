using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sagar";
            Countries countries = Countries.INDIA;

            Console.WriteLine("My name is {0} and I am from {1}",name, countries);
        }
        
        enum Countries { INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND }
    }
}
