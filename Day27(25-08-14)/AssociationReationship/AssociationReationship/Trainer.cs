using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationReationship
{
    class Trainer
    {
        public Trainer()
        {
            TrainersLaptop = new Laptop();
        }

        public string Name { set; get; }
        public string Expert { set; get; }

        public Laptop TrainersLaptop { set; get; } 


    }
}
