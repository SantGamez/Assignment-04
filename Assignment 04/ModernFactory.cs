using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class ModernFactory : AbstractFactory
    {
        internal override House makeHouse()
        {
            var house = new House();
            house.setBasement(ProductType.MODERN);
            house.setStructure(ProductType.MODERN);
            house.setInterior(ProductType.MODERN);
            house.setRoof(ProductType.MODERN);
            return house;
        }

        internal override Duplex makeDuplex()
        {
            var duplex = new Duplex();
            duplex.setBasement(ProductType.MODERN);
            duplex.setStructure(ProductType.MODERN);
            duplex.setInterior(ProductType.MODERN);
            duplex.setRoof(ProductType.MODERN);
            return duplex;
        }
    }
}
