using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    class Employee : IEmployee, IPrinter
    {
        public int GetAge()
        {
            return 25;
        }

        public double CalculateSalary(double basic)
        {
            return 45454;
        }

        public void Print()
        {
            Console.WriteLine("Id: 652347, Name: Rana");   
        }
    }
}
