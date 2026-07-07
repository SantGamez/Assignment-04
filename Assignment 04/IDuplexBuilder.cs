using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal interface IDuplexBuilder
    {
        void buildBasement();

        void buildStructure();

        void buildInterior();

        void buildRoof();

        void getDuplex();
    }
}
