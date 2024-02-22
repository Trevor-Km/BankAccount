using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(string accNumber, decimal accBalance, string lastName, string firstName, decimal interestRate)
     : base(accNumber, accBalance, lastName, firstName)
        {
            this.interestRate = interestRate;
        }


        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value > 0)
                {
                    interestRate = value;


                    }
                else
                    Console.WriteLine("Interest rate should be a positive value");
                interestRate = 0.05m;
            }
        }

        public decimal calculateInterest(decimal interestRate, decimal accBalance)
        {
            return interestRate * accBalance;
        }

         public override void displayAccount()
        {
            drawLine();
            Console.WriteLine($"|  {"SAVINGS ACCOUNT",45} {"|",33}");
            drawLine();
            Console.WriteLine($"| {"Account Number",-25} | {AccNumber,50} |");
            drawLine();
            Console.WriteLine($"| {"Balance Amount ",-25} | {"$" + Balance,50} |");
            drawLine();
            Console.WriteLine($"| {"Last Name",-25} | {LastName,-50} |");
            drawLine();
            Console.WriteLine($"| {"First Name",-25} | {FirstName,-50} |");
            drawLine();
            Console.WriteLine($"| {"Interest Rate ",-25} | {"$" + InterestRate,50} |");
            drawLine();
            Console.WriteLine($"| {"Interest Amount ",-25} | {"$" + calculateInterest(InterestRate, Balance),50} |");
            drawLine();
        }


        public  override void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)

                Console.Write("-");
            Console.WriteLine("|");

        }


    }
}
