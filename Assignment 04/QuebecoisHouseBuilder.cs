using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class QuebecoisHouseBuilder: IHouseBuilder
    {
        private House house;

        // Constructor
        internal QuebecoisHouseBuilder()
        {
            this.house = new House();
        }

        // Builds the basement of the house
        public void buildBasement()
        {
            house.setBasement(ProductType.QUEBECOIS);
        }

        // Builds the structure of the house
        public void buildStructure()
        {
            house.setStructure(ProductType.QUEBECOIS);
        }

        // Builds the interior of the house
        public void buildInterior()
        {
            house.setInterior(ProductType.QUEBECOIS);
        }

        // Builds the roof of the house
        public void buildRoof()
        {
            house.setRoof(ProductType.QUEBECOIS);
        }

        // Gets the house object
        public House getHouse()
        {
            return this.house;
        }
    }
}
