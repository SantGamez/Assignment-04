using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class PersianFactory : AbstractFactory
    {
        internal override House makeHouse()
        {
            var house = new House();
            house.setBasement(ProductType.PERSIAN);
            house.setStructure(ProductType.PERSIAN);
            house.setInterior(ProductType.PERSIAN);
            house.setRoof(ProductType.PERSIAN);
            return house;
        }

        internal override Duplex makeDuplex()
        {
            var duplex = new Duplex();
            duplex.setBasement(ProductType.PERSIAN);
            duplex.setStructure(ProductType.PERSIAN);
            duplex.setInterior(ProductType.PERSIAN);
            duplex.setRoof(ProductType.PERSIAN);
            return duplex;
        }
    }
}
