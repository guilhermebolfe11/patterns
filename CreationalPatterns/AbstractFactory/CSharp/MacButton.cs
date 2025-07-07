using System;

namespace AbstractFactory
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Render a button in MacOS style.");
        }
    }
}

