using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Account account = new Account("421",421.0m,"KM","Trevor");
         //   account.displayAccount();
           Console.WriteLine("Please Enter Account Number");
            String accNumber = Console.ReadLine();
            Console.WriteLine("Please Enter Account Balance");
            decimal accBalance= decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please Enter First Name");
            string firstName = Console.ReadLine();
            Account account2 = new Account(accNumber,accBalance,lastName,firstName);
           // account2.displayAccount();
           SavingsAccount saving = new SavingsAccount(accNumber,accBalance,lastName,firstName,0.05m);
           saving.displayAccount();
        }
    }
}
