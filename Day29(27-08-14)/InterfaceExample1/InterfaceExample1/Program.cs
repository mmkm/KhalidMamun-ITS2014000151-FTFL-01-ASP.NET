using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter e1 = new Employee();
            IPrinter a1 = new Account();
            IPrinter d1 = new Department();

            ICollection<string> names = new List<string>();

            IEnumerable<string> nameList = new List<string>();


            List<IPrinter> printers = new List<IPrinter>();
            printers.Add(e1);
            printers.Add(a1);
            printers.Add(d1);

            foreach (IPrinter printer in printers)
            {
                printer.Print();
            }

            Console.ReadKey();

        }
    }
}
