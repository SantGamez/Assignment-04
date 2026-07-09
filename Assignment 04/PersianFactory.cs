using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class PersianFactory : AbstractFactory
    {
        // This is a concrete factory class that implements the abstract factory methods to create Persian-style houses and duplexes.
        internal override House makeHouse()
        {
            return new House();
        }

        internal override Duplex makeDuplex()
        {
            return new Duplex();
        }
    }
}
