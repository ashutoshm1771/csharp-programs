using System;
using System.Collections.Generic;
using System.Text;

namespace BankyStuffLibrary
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string Name,decimal initialBalance)
        {
            this.Owner = Name;
            MakeDeposit(initialBalance,DateTime.Now,"Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        } 
        public void MakeDeposit(decimal amount,DateTime date,string note)
        {
            if ( amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), " Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if( Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal"); 
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            // Header of the Table
            report.AppendLine("Date\t\tAmount   \tNote");
            foreach(var item in allTransactions)
            {
                // Rows of the Table
                report.Append($"{item.Date.ToShortDateString()}\t{item.amount}\t{item.Notes}\n");
            }
            return report.ToString();
        }
    }
}
