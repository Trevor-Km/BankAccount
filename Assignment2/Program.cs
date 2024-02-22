using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("421", 421.0m, "KM", "Trevor");

            Console.WriteLine("Press 1 for Chequing or 2 for Savings");

            if (Console.ReadLine().Equals("1"))
            {
                Console.WriteLine("Please Enter Account Number");
                String accNumber = Console.ReadLine();
                Console.WriteLine("Please Enter Account Balance");
                decimal accBalance = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please Enter First Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please Enter Transaction Fee");
                decimal transactionFee = decimal.Parse(Console.ReadLine());
                ChequingAccount cheq = new ChequingAccount(accNumber, accBalance, lastName,firstName, transactionFee);
               Console.WriteLine("Please Enter Withdrawal Amount");
                decimal withDrawAmount = decimal.Parse(Console.ReadLine());
                cheq.displayAccount();
                cheq.credit(100);

                Console.WriteLine($"|  {"CHEQUING BALANCE",45} {"|",33}");
                drawLine();
                Console.WriteLine($"| {"Balance Amount Before Debit ",-25} | {"$" + cheq.Balance,-45}   |");
                drawLine();
                Console.WriteLine($"| {"Balance Amount After Debit ",-25}  | {"$" + (cheq.Balance-withDrawAmount-transactionFee),-45}   |");
                drawLine();
                Console.WriteLine();
                cheq.debit(withDrawAmount);


            }
            else
            {
               
                Console.WriteLine("Please Enter Account Number");
                String accNumber = Console.ReadLine();
                Console.WriteLine("Please Enter Account Balance");
                decimal accBalance = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please Enter First Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please Enter Interest Rate");
                decimal interestRate = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter deposit amount");
                decimal transactionAmount = decimal.Parse(Console.ReadLine());

                SavingsAccount saving = new SavingsAccount(accNumber, accBalance, lastName, firstName, interestRate);
                decimal interestAmount = saving.calculateInterest(interestRate, accBalance);
                saving.credit(10);
                saving.displayAccount();
                 
               

                Console.WriteLine($"|  {"SAVINGS BALANCE",45} {"|",33}");
                drawLine();
                Console.WriteLine($"| {"Balance Amount Before Interest ",-25} | {"$" + saving.Balance,-45}|");
                drawLine();              
                Console.WriteLine($"| {"Balance Amount After Interest ",-25}  | {"$" + saving.credit(interestAmount),-45}|");
                drawLine();

              

                Console.WriteLine($"|  {"SAVINGS BALANCE",45} {"|",33}");
                drawLine();
                Console.WriteLine($"| {"Balance Amount Before Deposit ",-25} | {"$" + saving.Balance,-45} |");
                drawLine();
                Console.WriteLine($"| {"Balance Amount After Deposit ",-25}  | {"$" + (saving.Balance + transactionAmount),-45} |");
                drawLine();
            }
        }
        //public void displayBalance()
        //{
        //    drawLine();
        //    Console.WriteLine($"|  {"SAVINGS BALANCE",45} {"|",33}");
        //    drawLine();
        //    Console.WriteLine($"| {"Account Number",-25} | {saving.AccNumber,50} |");
        //    drawLine();
        //    Console.WriteLine($"| {"Balance Amount ",-25} | {"$" + Balance,50} |");
        //    drawLine();
        //    Console.WriteLine($"| {"Last Name",-25} | {LastName,-50} |");
        //    drawLine();
        //    Console.WriteLine($"| {"First Name",-25} | {FirstName,-50} |");
        //    drawLine();
        //}


        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)

                Console.Write("-");
            Console.WriteLine("|");

        }


    }
}
