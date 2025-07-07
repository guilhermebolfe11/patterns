using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IGUIFactory factory;
            string os = Environment.OSVersion.Platform.ToString();
            if (os.Contains("Win"))
                factory = new WinFactory();
            else
                factory = new MacFactory();

            var button = factory.CreateButton();
            var checkbox = factory.CreateCheckbox();
            button.Paint();
            checkbox.Paint();
        }
    }
}
