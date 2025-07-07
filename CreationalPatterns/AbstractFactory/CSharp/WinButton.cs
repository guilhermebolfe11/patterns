using System;

namespace AbstractFactory
{
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Render a button in Windows style.");
        }
    }
}

