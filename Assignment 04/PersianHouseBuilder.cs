using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class PersianHouseBuilder:IHouseBuilder
    {
        private House house;

        internal PersianHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            house.setBasement(ProductType.PERSIAN);
        }

        public void buildStructure()
        {
            house.setStructure(ProductType.PERSIAN);
        }

        public void buildInterior()
        {
            house.setInterior(ProductType.PERSIAN);
        }

        public void buildRoof()
        {
            house.setRoof(ProductType.PERSIAN);
        }

        // The getHouse method returns the constructed house.
        public House getHouse()
        {
            return this.house;
        }
    }
}
