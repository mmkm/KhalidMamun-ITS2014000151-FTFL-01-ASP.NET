using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            aStudent.RegNo = "8778";
            Do(aStudent);
            //aStudent.RegNo =??????
            int b = 10;
            Do1(b);
            //b =???
        }

        private static void Do(Student aStudent)
        {
            aStudent.RegNo = "0000";
        }

        private static void Do1(int a)
        {
            a = 100;
        }
    }
}
