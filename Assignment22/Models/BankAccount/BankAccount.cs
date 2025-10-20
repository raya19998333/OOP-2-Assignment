using Assignment22.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.BankAccount
{
    internal class BankAccount
    {
        // Constructor to initialize a bank account
        private int accountNumber;
        private double balance;
        private string owner;

        // Static field to keep track of total accounts created
        private static int totalAccounts = 0;

        public BankAccount(int accountNumber, string owner, double initialBalance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = initialBalance >= 0 ? initialBalance : 0;
            totalAccounts++; // زيادة عدد الحسابات
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                    balance = value;
            }
        }
        public string Owner
        {
            get { return owner; }
            private set { owner = value; }
        }
        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        // Method to withdraw money from the account
        public void withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
        // Static method to get total number of accounts created
        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Total Bank Accounts Created: {totalAccounts}");
        }
        // Method to print account details
        public void PrintAccountDetails()
        {

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine("---------------------------");
        }


    }



}

