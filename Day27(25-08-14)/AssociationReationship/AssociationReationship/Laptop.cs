using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationReationship
{
    class Laptop
    {
        public string Brand { set; get; }
        public double PriceOfRAM { set; get; }
        public double PriceOfProcessor { set; get; }
        public double PriceOfHDD { set; get; }

        public double GetSaleableItemsPrice()
        {
            Calculator aCalculator = new Calculator();
            return aCalculator.Add(aCalculator.Add(PriceOfRAM, PriceOfProcessor), PriceOfHDD);
        }

    }
}
