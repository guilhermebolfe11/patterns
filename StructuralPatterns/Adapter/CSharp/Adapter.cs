using System;

namespace Adapter;

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string Request()
    {
        var charArray = _adaptee.SpecificRequest().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
