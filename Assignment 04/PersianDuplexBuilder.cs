using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class PersianDuplexBuilder: IDuplexBuilder
    {
        private Duplex duplex;

        internal PersianDuplexBuilder()
        {
            this.duplex = new Duplex();
        }

        public void buildBasement()
        {
            duplex.setBasement(ProductType.PERSIAN);
        }

        public void buildStructure()
        {
            duplex.setStructure(ProductType.PERSIAN);
        }

        public void buildInterior()
        {
            duplex.setInterior(ProductType.PERSIAN);
        }

        public void buildRoof()
        {
            duplex.setRoof(ProductType.PERSIAN);
        }

        // The getDuplex method returns the constructed duplex.
        public Duplex getDuplex()
        {
            return this.duplex;
        }
    }
}
