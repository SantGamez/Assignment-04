using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class ModernHouseBuilder:IHouseBuilder
    {
        private House house;

        internal ModernHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            house.setBasement(ProductType.MODERN);
        }

        public void buildStructure()
        {
            house.setStructure(ProductType.MODERN);
        }

        public void buildInterior()
        {
            house.setInterior(ProductType.MODERN);
        }

        public void buildRoof()
        {
            house.setRoof(ProductType.MODERN);
        }

        // The getHouse method returns the constructed house.
        public House getHouse()
        {
            return this.house;
        }
    }
}
