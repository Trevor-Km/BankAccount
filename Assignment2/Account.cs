using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Account
    {
        private string accNumber;
        private decimal accBalance;
        private string lastName;
        private string firstName;

        public Account(string accNumber, decimal accBalance, string lastName, string firstName)
        {
            AccNumber = accNumber;
            Balance = accBalance;
            LastName = lastName;
            FirstName = firstName;
        }
        public string AccNumber
        {
            get
            {
                return this.accNumber;
            }
            set
            {
                this.accNumber = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.accBalance;
            }
            set
            {
                if (accBalance >= 0.0m)
                {
                    this.accBalance = value;
                }
                else
                {
                    this.accBalance = 0;
                    Console.WriteLine("Account initial balance must be a positive value");
                }
            }

        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public virtual decimal credit(decimal amount)
        {
            return Balance + amount;
        }

        public virtual bool debit(decimal amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Debit amount exceeded account balance");

                return false;
            }
            Balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully");
            return true;

        }


        public virtual void displayAccount()
        {
            drawLine();
            Console.WriteLine($"|  {"ACCOUNT",45} {"|",33}");
            drawLine();
            Console.WriteLine($"| {"Account Number",-25} | {AccNumber,50} |");
            drawLine();
            Console.WriteLine($"| {"Balance Amount ",-25} | {"$" + Balance,50} |");
            drawLine();
            Console.WriteLine($"| {"Last Name",-25} | {LastName,-50} |");
            drawLine();
            Console.WriteLine($"| {"First Name",-25} | {FirstName,-50} |");
            drawLine();
        }


        public virtual  void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)

                Console.Write("-");
            Console.WriteLine("|");

        }
    }
}


