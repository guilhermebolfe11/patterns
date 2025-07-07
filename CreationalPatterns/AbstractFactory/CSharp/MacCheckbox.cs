using System;

namespace AbstractFactory
{
    public class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Render a checkbox in MacOS style.");
        }
    }
}

