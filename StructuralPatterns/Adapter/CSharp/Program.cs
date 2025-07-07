using System;

namespace Adapter;

class Program
{
    static void ClientCode(ITarget target)
    {
        Console.WriteLine(target.Request());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Client: I can work just fine with the Target objects:");
        ITarget target = new DefaultTarget();
        ClientCode(target);

        Console.WriteLine();

        var adaptee = new Adaptee();
        Console.WriteLine("Client: The Adaptee class has a weird interface. See, I don't understand it:");
        Console.WriteLine($"Adaptee: {adaptee.SpecificRequest()}");

        Console.WriteLine();

        Console.WriteLine("Client: But I can work with it via the Adapter:");
        ITarget adapter = new Adapter(adaptee);
        ClientCode(adapter);
    }
}
