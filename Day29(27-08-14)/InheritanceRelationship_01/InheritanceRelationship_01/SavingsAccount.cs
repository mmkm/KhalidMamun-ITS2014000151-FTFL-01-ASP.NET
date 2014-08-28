namespace InheritanceRelationship_01
{
    class SavingsAccount : Account
    {
        public SavingsAccount(string accountNo, string customerName, double interestAmount) : base(accountNo, customerName)
        {
            this.InterestAmount = interestAmount;
        }

        public override void Transfer(double amount, string toAccount)
        {
            //this is the implementation
        }

        public double InterestAmount { set; get; }

        public override string GetInfo()
        {
            return base.GetInfo() + " Interest Amount: " + InterestAmount;
        }

        public new string Deposit(double amount)
        {
            return "something";
        }

        public sealed override string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Insuffcient balance";
            }
        }
    }
}
