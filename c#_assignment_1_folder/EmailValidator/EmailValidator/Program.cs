using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EmailValidator
{
    internal class Program
    {
        public static bool IsValidEMail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(email);
        }
        static void Main(string[] args)
        {
            string emailInput;
            emailInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine(IsValidEMail(emailInput));

        }
    }
}
