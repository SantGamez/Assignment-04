using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal interface IHouseBuilder
    {
        // Method to build the basement of the house
        void buildBasement();

        // Method to build the structure of the house
        void buildStructure();

        // Method to build the interior of the house
        void buildInterior();

        // Method to build the roof of the house
        void buildRoof();

        // Method to get the constructed house
        House getHouse();

    }
}
