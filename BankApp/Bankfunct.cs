using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class Bankfunct
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get 
            {
                decimal balance = 0;

                foreach (var item in allTransactions)
                {
                    balance += item.Amount; 
                }
                return balance;
            } 
        
        }

        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();
        public Bankfunct (string name, decimal initialBalance)
        {
            this.Owner = name;
            //          this.Balance = initialBalance;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;        }
        public void MakeDeposit (decimal amount, DateTime date, string note) 
        {
            if (amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be Positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithrawl(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl must be Positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not Sufficient Fund");
            }
            var withrawl = new Transaction(-amount, date, note);
            allTransactions.Add(withrawl);
        }
        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNotes");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Note}");
            }
            return report.ToString();
        }

    }
}
