using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class FactoryInterior
    {
        internal static IInterior Factory(ProductType type)
        {
            IInterior IInterior = null;

            switch (type)
            {
                case ProductType.QUEBECOIS:
                    IInterior = new InteriorQuebecois();
                    break;
                case ProductType.PERSIAN:
                    IInterior = new InteriorPersian();
                    break;
                case ProductType.MODERN:
                    IInterior = new InteriorModern();
                    break;
            }
            return IInterior;
        }
    }
}
