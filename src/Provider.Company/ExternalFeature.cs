using App.Shared;

namespace App.Provider.Company;

public class ExternalFeature : IFeature
{
    public void Test()
    {
        Console.WriteLine("Hello from a extended feature");
    }
}
