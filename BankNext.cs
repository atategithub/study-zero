using System;

namespace BankNext

{
    public class BankNext
    {
        private static int accountNumberSeed = 1818181818;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        public BankNext(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            var account = new BankNext("<Tate>", 18000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
    }
}