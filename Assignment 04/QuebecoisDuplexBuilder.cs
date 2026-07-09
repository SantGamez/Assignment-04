using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class QuebecoisDuplexBuilder: IDuplexBuilder
    {
        private Duplex duplex;

        internal QuebecoisDuplexBuilder()
        {
            this.duplex = new Duplex();
        }

        public void buildBasement()
        {
            duplex.setBasement(ProductType.QUEBECOIS);
        }

        public void buildStructure()
        {
            duplex.setStructure(ProductType.QUEBECOIS);
        }

        public void buildInterior()
        {
            duplex.setInterior(ProductType.QUEBECOIS);
        }

        public void buildRoof()
        {
            duplex.setRoof(ProductType.QUEBECOIS);
        }

        // The getDuplex method returns the constructed duplex.
        public Duplex getDuplex()
        {
            return this.duplex;
        }
    }
}
