using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal abstract class AbstractFactory
    {
        // These are static instances of the concrete factories for each product type.
        private static AbstractFactory QuebecoisFactory = new QuebecoisFactory();
        private static AbstractFactory PersianFactory = new PersianFactory();
        private static AbstractFactory ModernFactory = new ModernFactory();

        // This method returns the appropriate factory based on the product type.
        internal static AbstractFactory GetFactory (ProductType type)
        {
            switch (type)
            {
                case ProductType.QUEBECOIS:
                    return QuebecoisFactory;
                case ProductType.PERSIAN:
                    return PersianFactory;
                case ProductType.MODERN:
                    return ModernFactory;
            }
            return null;
        }

        // These are abstract methods that must be implemented by the concrete factories to create specific houses and duplexes.
        internal abstract House makeHouse();

        internal abstract Duplex makeDuplex();


    }
}
