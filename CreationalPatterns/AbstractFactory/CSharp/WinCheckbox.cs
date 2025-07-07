using System;

namespace AbstractFactory
{
    public class WinCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Render a checkbox in Windows style.");
        }
    }
}

