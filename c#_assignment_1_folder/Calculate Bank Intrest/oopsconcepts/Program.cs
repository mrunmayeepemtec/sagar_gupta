using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsconcepts
{
    class Bank
    {
        public int bank_id;
        public int loan_amount;
        static Bank()
        {
            Console.WriteLine("please note rate of intrest is 10% per annum ");
        }
        public void calculateIntrest(int loan_amount)
        {
            int intrest = (loan_amount * 10) / 100;
            Console.WriteLine("Total intrest of the given amount is:"+intrest);
        }
    }
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.bank_id = Convert.ToInt32(Console.ReadLine());
            
            bank.calculateIntrest(bank.loan_amount = Convert.ToInt32(Console.ReadLine()));


        }
    }
}
