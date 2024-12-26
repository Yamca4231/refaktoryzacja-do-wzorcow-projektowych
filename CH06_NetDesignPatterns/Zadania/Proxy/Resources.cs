// Interfejs zasobu
public interface IResource
{
    void Access();
}

// Zasób dostępny bez ograniczeń
public class PublicResource : IResource
{
    public void Access()
    {
        Console.WriteLine("Accessing Public Resource: No restrictions.");
    }
}

// Zasób chroniony
public class ProtectedResource : IResource
{
    private string _password;

    public ProtectedResource(string password)
    {
        _password = password;
    }

    public void Access()
    {
        Console.WriteLine("Accessing Protected Resource: Restricted access.");
    }

    public bool ValidatePassword(string password)
    {
        return _password == password;
    }
}

// Proxy zasobu
public class ResourceProxy : IResource
{
    private IResource _resource;
    private string _password;

    public ResourceProxy(IResource resource, string password)
    {
        _resource = resource;
        _password = password;
    }

    public void Access()
    {
        Console.Write("Enter password: ");
        string input = Console.ReadLine();

        if (input == _password)
        {
            _resource.Access();
        }
        else
        {
            Console.WriteLine("Access denied: Incorrect password.");
        }
    }
}