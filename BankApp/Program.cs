using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Bankfunct("Kendra", 10000);
         //   Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} !");
            var account1 = new Bankfunct("Scott", 20000);
            account.MakeWithrawl(120, DateTime.Now, "Hammock");
         //   Console.WriteLine($"After Withdrawl1 Available Amount is: {account.Balance}");
              account.MakeWithrawl(50, DateTime.Now, "Xbox Game");
            //account.MakeWithrawl(50, DateTime.Now, "Xbox Game");
            //   Console.WriteLine($"After Withdrawl2 Available Amount is: {account.Balance}");
            Console.WriteLine(account.GetAccountHistory());
            //try
            //{
            //    account.MakeWithrawl(75000,DateTime.Now,"Attempt to Overdraw");
            //}
            //catch (InvalidOperationException e)
            //{

            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            //try
            //{
            //    var invalidAccount = new Bankfunct("Invalid Amount", -55);            
            //}
            //catch (ArgumentOutOfRangeException e)
            //{

            //    Console.WriteLine("Exception caught creating account with negative Balance");
            //    Console.WriteLine(e.ToString());
            //}
            //account.MakeWithrawl(50, DateTime.Now, "Xbox Game");
            //Console.WriteLine($"After Withdrawl2 Available Amount is: {account.Balance}");
            //account.MakeDeposit(-300, DateTime.Now, "stealing");
            //Console.WriteLine($"After Deposit Available Amount is: {account.Balance}");
            //Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} !");
            Console.ReadLine();        }
    }
}
