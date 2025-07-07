namespace Adapter;

public class DefaultTarget : ITarget
{
    public string Request()
    {
        return "Target: The default target's behavior.";
    }
}

