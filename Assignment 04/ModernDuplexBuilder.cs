using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class ModernDuplexBuilder: IDuplexBuilder
    {
        private Duplex duplex;

        internal ModernDuplexBuilder()
        {
            this.duplex = new Duplex();
        }

        public void buildBasement()
        {
            duplex.setBasement(ProductType.MODERN);
        }

        public void buildStructure()
        {
            duplex.setStructure(ProductType.MODERN);
        }

        public void buildInterior()
        {
            duplex.setInterior(ProductType.MODERN);
        }

        public void buildRoof()
        {
            duplex.setRoof(ProductType.MODERN);
        }

        public Duplex getDuplex()
        {
            return this.duplex;
        }
    }
}
