using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
    
        internal class BankAccount1
        {
            public string AccountNumber { get; set; }
            public decimal Balance { get; protected set; }

            public BankAccount1(string accountNumber, decimal initialBalance = 0)
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }

            public virtual void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
                }
                else
                {
                    Console.WriteLine("Deposit amount must be positive.");
                }
            }

            public virtual void Withdraw(decimal amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {Balance:C}");
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
                }
            }

            public virtual void DisplayDetails()
            {
                Console.WriteLine("Bank Account Details:");
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Balance: {Balance:C}");
            }
        }

        internal sealed class SavingsAccount : BankAccount1
        {
            public decimal InterestRate { get; set; } // Annual interest rate as a percentage

            public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
                : base(accountNumber, initialBalance)
            {
                InterestRate = interestRate;
            }

            public decimal CalculateInterest(int months)
            {
                // Simple interest calculation for demonstration
                decimal interest = Balance * (InterestRate / 100) * (months / 12m);
                return interest;
            }

            public void ApplyInterest(int months)
            {
                decimal interest = CalculateInterest(months);
                Balance += interest;
                Console.WriteLine($"Interest applied for {months} month(s): {interest:C}. New Balance: {Balance:C}");
            }
        }
    }
