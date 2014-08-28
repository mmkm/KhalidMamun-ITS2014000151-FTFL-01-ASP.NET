using System;
using System.Collections.Generic;

namespace InheritanceRelationship_01
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckingAccount chk1 = new CheckingAccount("Chl-001", "Sumi", 5000);
            chk1.Deposit(10000);

            SavingsAccount sv1 = new SavingsAccount("sv-001", "Sharif", 4500);
            sv1.Deposit(3000);

            List<Account> accounts = new List<Account>();
            accounts.Add(sv1);
            accounts.Add(chk1);

            Account anAcount;

            Account acc10 = sv1;
            acc10.Withdraw(200);
            acc10.Deposit(300);

            sv1.Deposit(3000);


            foreach (Account anAccount in accounts)
            {
                anAccount.Withdraw(4000);
            }

            foreach (Account anAccount in accounts)
            {
                Console.WriteLine(anAccount.GetInfo());
            }
            
            Console.ReadKey();
        }
    }
}
