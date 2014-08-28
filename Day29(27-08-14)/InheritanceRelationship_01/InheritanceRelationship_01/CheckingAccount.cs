namespace InheritanceRelationship_01
{
    class CheckingAccount : Account
    {
        public CheckingAccount(string accountNo, string customerName, double serviceCharge) : base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public override void Transfer(double amount, string toAccount)
        {
            //implementation
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Service charge: " + ServiceCharge + " No of Transactions: " + NoOfTransactions;
        }

        public double ServiceCharge { set; get; }
        public double NoOfTransactions { private set; get; }

    }
}
