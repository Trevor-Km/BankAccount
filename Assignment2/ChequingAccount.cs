using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ChequingAccount : Account
    {
        private decimal transactionFee;

        public ChequingAccount(string accNumber, decimal accBalance, string lastName, string firstName, decimal transactionFee)
     : base(accNumber, accBalance, lastName, firstName)
        {
            this.transactionFee = TransactionFee;
        }


        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                if (value > 0)
                {
                    transactionFee = value;


                }
                else
                    Console.WriteLine("Transaction fee should be a positive value");
                transactionFee = 1.5m;
            }
        }

        public decimal calculateInterest(decimal interestRate, decimal accBalance)
        {
            return interestRate * accBalance;
        }

        new public void displayAccount()
        {
            drawLine();
            Console.WriteLine($"|  {"CHEQUING ACCOUNT",45} {"|",33}");
            drawLine();
            Console.WriteLine($"| {"Account Number",-25} | {AccNumber,50} |");
            drawLine();
            Console.WriteLine($"| {"Balance Amount ",-25} | {"$" + Balance,50} |");
            drawLine();
            Console.WriteLine($"| {"Last Name",-25} | {LastName,-50} |");
            drawLine();
            Console.WriteLine($"| {"First Name",-25} | {FirstName,-50} |");
            drawLine();
            Console.WriteLine($"| {"Transaction Fee ",-25} | {"$" + TransactionFee,50} |");
            drawLine();
            
        }


        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)

                Console.Write("-");
            Console.WriteLine("|");

        }


    }
}
