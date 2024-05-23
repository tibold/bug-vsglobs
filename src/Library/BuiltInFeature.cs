using App.Shared;

namespace App.Library;

public class BuiltInFeature : IFeature
{
    public void Test()
    {
        Console.WriteLine("Hello from a builtin feature");
    }
}
