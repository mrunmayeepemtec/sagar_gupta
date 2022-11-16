using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    internal class DivideByZero
    {
        int result;
        DivideByZero()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1/num2;
            }

            catch(Exception e)
            {
                Console.WriteLine("Exception Caught: {0}", e);
            }

            finally
            {
                Console.WriteLine("Result :{0}", result);
            }

        }
        static void Main(string[] args)
        {
            DivideByZero d = new DivideByZero();
            d.division(5, 5);

        }
    }
}
