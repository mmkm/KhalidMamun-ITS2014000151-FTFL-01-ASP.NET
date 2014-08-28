using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    class Account : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("No: 23. Balance: 65634");
        }
    }
}
