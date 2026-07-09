using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class DuplexEngineer
    {
        internal IDuplexBuilder iBuilder;

        internal DuplexEngineer(IDuplexBuilder builder)
        {
            this.iBuilder = builder;
        }

        // The ConstructDuplex calls the appropriate methods on the builder to build each component of the duplex.
        internal void ConstructDuplex()
        {
            iBuilder.buildBasement();
            iBuilder.buildStructure();
            iBuilder.buildRoof();
            iBuilder.buildInterior();
        }

        // The GetDuplex method returns the constructed duplex from the builder.
        internal Duplex GetDuplex()
        {
            return iBuilder.getDuplex();
        }
    }
}
