namespace AbstractFactory
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton() => new WinButton();
        public ICheckbox CreateCheckbox() => new WinCheckbox();
    }
}

