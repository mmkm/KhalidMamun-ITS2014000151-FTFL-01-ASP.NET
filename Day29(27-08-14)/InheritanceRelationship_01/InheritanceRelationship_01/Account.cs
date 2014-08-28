namespace InheritanceRelationship_01
{
    internal abstract class Account
    {
        public Account(string accountNo, string customerName) : this()
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }
        public Account()
        {
            Balance = 0;
        }

        public string AccountNo { set; get; }
        public string CustomerName { set; get; }
        public double Balance { private set; get; }

        //public abstract void M1();
        public abstract void Transfer(double amount, string toAccount);

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Amount has been diposited";
        }

        public virtual string GetInfo()
        {
            return "Account no: " + AccountNo + " Customer Name: " + CustomerName + " Balance: " + Balance;
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Amount has been withdrawn";
        }
    }
}
