// Klasa sklepu
public class Shop
{
    public void ProcessPayment(IPayment payment)
    {
        payment.Pay();
    }
}

// Interfejs płatności
public interface IPayment
{
    void Pay();
}

// Podstawowa klasa płatności kartą
public class CardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made using a card.");
    }
}

// Płatność gotówką
public class CashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made using cash.");
    }
}

// Płatność online
public class OnlinePayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made online.");
    }
}

// Dekorator bazowy
public abstract class PaymentDecorator : IPayment
{
    protected IPayment _payment;

    protected PaymentDecorator(IPayment payment)
    {
        _payment = payment;
    }

    public virtual void Pay()
    {
        _payment.Pay();
    }
}

// Dekorator: Powiadomienie SMS
public class SmsNotificationDecorator : PaymentDecorator
{
    public SmsNotificationDecorator(IPayment payment) : base(payment) { }

    public override void Pay()
    {
        base.Pay();
        Console.WriteLine("SMS notification sent for the payment.");
    }
}

// Dekorator: Dodanie punktów lojalnościowych
public class LoyaltyPointsDecorator : PaymentDecorator
{
    public LoyaltyPointsDecorator(IPayment payment) : base(payment) { }

    public override void Pay()
    {
        base.Pay();
        Console.WriteLine("Loyalty points added to the account.");
    }
}

// Dekorator: Przekierowanie na stronę główną
public class RedirectDecorator : PaymentDecorator
{
    public RedirectDecorator(IPayment payment) : base(payment) { }

    public override void Pay()
    {
        base.Pay();
        Console.WriteLine("Redirecting to the home page.");
    }
}