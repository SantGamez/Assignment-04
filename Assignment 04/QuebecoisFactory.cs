using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class QuebecoisFactory: AbstractFactory
    {
        internal override House makeHouse()
        {
            return new House();
        }

        internal override IBasement makeBasement()
        {
            return new BasementQuebecois();
        }
    }
}
