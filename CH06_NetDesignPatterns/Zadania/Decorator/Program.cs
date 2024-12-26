class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();

        Console.WriteLine("Choose a payment method:");
        Console.WriteLine("1. Card Payment");
        Console.WriteLine("2. Cash Payment");
        Console.WriteLine("3. Online Payment");
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();

        IPayment payment;

        switch (choice)
        {
            case "1":
                payment = new CardPayment();
                // Dekoracja płatności kartą
                payment = new SmsNotificationDecorator(payment);
                payment = new LoyaltyPointsDecorator(payment);
                payment = new RedirectDecorator(payment);
                break;
            case "2":
                payment = new CashPayment();
                break;
            case "3":
                payment = new OnlinePayment();
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Card Payment.");
                payment = new CardPayment();
                // Dekoracja płatności kartą
                payment = new SmsNotificationDecorator(payment);
                payment = new LoyaltyPointsDecorator(payment);
                payment = new RedirectDecorator(payment);
                break;
        }

        // Przetwarzanie płatności w sklepie
        shop.ProcessPayment(payment);
    }
}