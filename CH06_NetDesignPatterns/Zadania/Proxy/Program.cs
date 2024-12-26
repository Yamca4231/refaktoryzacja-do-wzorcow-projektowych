class Program
{
    static void Main(string[] args)
    {
        IResource publicResource = new PublicResource();
        IResource protectedResource = new ResourceProxy(new ProtectedResource("secure123"), "secure123");

        while (true)
        {
            Console.WriteLine("\nSelect a resource to access:");
            Console.WriteLine("1. Public Resource");
            Console.WriteLine("2. Protected Resource");
            Console.WriteLine("0. Exit");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Exiting...");
                break;
            }

            switch (choice)
            {
                case "1":
                    publicResource.Access();
                    break;
                case "2":
                    protectedResource.Access();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
