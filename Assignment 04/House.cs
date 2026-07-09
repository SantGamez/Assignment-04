using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class House
    {
        // The House class represents a house with its components: basement, structure, interior, and roof.
        private IBasement? basement;
        private IStructure? structure;
        private IInterior? interior;
        private IRoof? roof;

        internal void setBasement(ProductType type)
        {
            this.basement = FactoryBasement.Factory(type);
        }

        internal void setStructure(ProductType type)
        {
            this.structure = FactoryStructure.Factory(type);
        }

        internal void setInterior(ProductType type)
        {
            this.interior = FactoryInterior.Factory(type);
        }

        internal void setRoof(ProductType type)
        {
            this.roof = FactoryRoof.Factory(type);
        }

        // The displayHouse method displays the details of the house by calling the Display method of each component.
        internal void displayHouse()
        {
            Console.WriteLine($"House is ready:");
            basement?.Display();
            structure?.Display();
            interior?.Display();
            roof?.Display();
        }
    }
}
