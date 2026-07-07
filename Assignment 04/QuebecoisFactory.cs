using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class QuebecoisFactory : AbstractFactory
    {
        internal override House makeHouse()
        {
            var house = new House();
            house.setBasement(ProductType.QUEBECOIS);
            house.setStructure(ProductType.QUEBECOIS);
            house.setInterior(ProductType.QUEBECOIS);
            house.setRoof(ProductType.QUEBECOIS);
            return house;
        }

        internal override Duplex makeDuplex()
        {
            var duplex = new Duplex();
            duplex.setBasement(ProductType.QUEBECOIS);
            duplex.setStructure(ProductType.QUEBECOIS);
            duplex.setInterior(ProductType.QUEBECOIS);
            duplex.setRoof(ProductType.QUEBECOIS);
            return duplex;
        }
    }
}
