using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class FactoryRoof
    {
        // Factory method to create different types of roofs based on the ProductType enum
        internal static IRoof Factory(ProductType type)
        {
            IRoof IRoof = null;

            switch (type)
            {
                case ProductType.QUEBECOIS:
                    IRoof = new RoofQuebecois();
                    break;
                case ProductType.PERSIAN:
                    IRoof = new RoofPersian();
                    break;
                case ProductType.MODERN:
                    IRoof = new RoofModern();
                    break;
            }
            return IRoof;
        }
    }
}
