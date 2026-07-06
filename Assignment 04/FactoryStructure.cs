using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class FactoryStructure
    {
        internal static IStructure Factory(ProductType type)
        {
            IStructure IStructure = null;

            switch (type)
            {
                case ProductType.QUEBECOIS:
                    IStructure = new StructureQuebecois();
                    break;
                case ProductType.PERSIAN:
                    IStructure = new StructurePersian();
                    break;
                case ProductType.MODERN:
                    IStructure = new StructureModern();
                    break;
            }
            return IStructure;
        }
    }
}
