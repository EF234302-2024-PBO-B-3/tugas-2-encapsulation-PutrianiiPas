using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        // Deklarasi atribut private
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        // Properti public berisi metode set dan get
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                // Validasi
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _accountNumber = value;
                }
                else
                {
                    _accountNumber = "Unknown";
                }
            }
        }
        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                // Validasi
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _accountHolder = value;
                }
                else
                {
                    _accountHolder = "Unknown";
                }
            }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                // Validasi
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    _balance = 0.0;
                }
            }
        }

        // Konstuktor memakai properti utk validasi sesuai aturan
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Metode utk menambahkan uang ke saldo
        public void Deposit(double amount)
        {
            // Validasi
            if (amount >= 0)
            {
                _balance += amount;
            }
        }

        // Metode utk mengurangi uang dari saldo
        public void Withdraw(double amount)
        {
            // Validasi
            if (amount >= 0 && _balance >= amount)
            {
                _balance -= amount;
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}