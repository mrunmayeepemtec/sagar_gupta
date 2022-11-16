using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullRefrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
           // Console.WriteLine(str.Substring(4));
           if(str.Length >0)
            {
                Console.WriteLine(str);
            }
        }
    }
}
