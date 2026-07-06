using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal abstract class AbstractFactory // Need to know what type it will be
    {
        internal abstract House makeHouse();

        internal abstract Duplex makeDuplex();


    }
}
