using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal interface IDuplexBuilder
    {
        // Method to build the basement of the duplex
        void buildBasement();

        // Method to build the structure of the duplex
        void buildStructure();

        // Method to build the interior of the duplex
        void buildInterior();

        // Method to build the roof of the duplex
        void buildRoof();

        // Method to get the constructed duplex
        Duplex getDuplex();
    }
}
