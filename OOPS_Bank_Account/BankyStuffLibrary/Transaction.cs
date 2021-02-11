using System;
using System.Collections.Generic;
using System.Text;

namespace BankyStuffLibrary
{
    public class Transaction
    {
        public decimal amount { get;  }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount,DateTime date, string note)
        {
            this.amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
