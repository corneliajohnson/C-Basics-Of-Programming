﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    public class Checkings
    {
        protected string menuSelect;
        protected double deposit;
        protected double withdrawl;
        protected double currentBalance = 0;
        public double finalBalance;

        public void SubMenu()
        {
            

            do
            {
                Console.WriteLine("Account Menu");
                Console.WriteLine("1 - Desposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Check Balance");
                Console.WriteLine("4 - Exit");
                Console.WriteLine();
                menuSelect = Console.ReadLine();

                if (menuSelect == "1")
                {
                    Deposit();
                }
                else if (menuSelect == "2")
                {
                    Withdraw();
                }
                else if (menuSelect == "3")
                {
                    Balance();
                }

            } while (menuSelect != "4");
        }

        public virtual void Deposit()
        { 
            Console.Write("Enter the deposit amount: "); 
            deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A total of ${deposit.ToString("F")} has been despoited into your account");
            currentBalance += deposit;
            Console.WriteLine($"Total Balance: ${currentBalance.ToString("F")}");
            Console.WriteLine();
        }

        public void Withdraw()
        {
            Console.Write("Enter withdrawal amount: ");
            withdrawl = Convert.ToDouble(Console.ReadLine());
            if (withdrawl > currentBalance)
            {
                Console.WriteLine("Sorry, you Don't have enough funds to witdraw that amount.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"You withdrew ${withdrawl.ToString("F")} form ${currentBalance.ToString("F")}");
                currentBalance -= withdrawl;
                Console.WriteLine($"Current Balance: ${currentBalance.ToString("F")}");
                Console.WriteLine();
            }
        }

        public virtual void Balance()
        {
            Console.WriteLine($"Checking Account Balance: ${currentBalance.ToString("F")}");
            Console.WriteLine();
        }
    }
}
