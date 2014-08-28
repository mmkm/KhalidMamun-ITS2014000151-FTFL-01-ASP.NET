using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    class Department : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Name: CSE. No of students 450");
        }
    }
}
