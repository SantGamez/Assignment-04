using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Assignment_04
{
    internal class FactoryBasement
    {
        internal static IBasement Factory(ProductType type)
        {
            IBasement IBasement = null;

            switch (type)
            {
                case ProductType.QUEBECOIS:
                    IBasement = new BasementQuebecois();
                    break;
                case ProductType.PERSIAN:
                    IBasement = new BasementPersian();
                    break;
                case ProductType.MODERN:
                    IBasement = new BasementModern();
                    break;
            }
            return IBasement;
        }
    }
}
