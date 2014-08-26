using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypeExample
{
    class Student
    {
        public string Name { set; get; }
        public string RegNo { set; get; }

        private string address;

        public string Address
        {
            set
            {
                if (value.Length >= 200000)
                {
                    throw new Exception();
                }
                else
                {
                    address = value;
                }
            }
        }

        public Student()
        {
            Name = "Anonymous";
            LoadAllResults();
        }

        public Student(string name)
        {
            Name = name;
        }

        private List<string> LoadAllResults()
        {

        }

    }
}
