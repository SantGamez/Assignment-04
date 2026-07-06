using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class Duplex
    {
        private IBasement? basement; // used ? because the basement can be null if not set
        private IStructure? structure;
        private IInterior? interior;
        private IRoof? roof;

        internal void setBasement(ProductType type)
        {
            this.basement = FactoryBasement.Factory(type);
        }

        internal void setStructure(ProductType type)
        {
            this.structure = FactoryStructure.Factory(type);
        }

        internal void setInterior(ProductType type)
        {
            this.interior = FactoryInterior.Factory(type);
        }

        internal void setRoof(ProductType type)
        {
            this.roof = FactoryRoof.Factory(type);
        }

        internal void displayDuplex()
        {
            basement?.Display();
            structure?.Display();
            interior?.Display();
            roof?.Display();
        }
    }
}
