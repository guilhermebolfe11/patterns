namespace AbstractFactory
{
    public class MacFactory : IGUIFactory

    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}