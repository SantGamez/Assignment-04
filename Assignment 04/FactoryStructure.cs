using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class FactoryStructure
    {
        // Factory method to create an instance of IStructure based on the provided ProductType
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
