using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class HouseEngineer
    {
        internal IHouseBuilder iBuilder;

        internal HouseEngineer (IHouseBuilder builder)
        {
            this.iBuilder = builder;
        }

        // The ConstructHouse method calls the appropriate methods on the builder to build each component of the house.
        internal void ConstructHouse()
        {
            iBuilder.buildBasement();
            iBuilder.buildStructure();
            iBuilder.buildRoof();
            iBuilder.buildInterior();
        }

        // The GetHouse method returns the constructed house from the builder.
        internal House GetHouse()
        {
            return iBuilder.getHouse();
        }
    }

}
