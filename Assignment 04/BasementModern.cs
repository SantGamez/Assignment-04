using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class BasementModern:IBasement
    {
        // Method to display the basement of the Modern house using the IBasement interface
        public void Display()
        {
            Console.WriteLine("Basement - Modern");
        }
    }
}
