public class EventDetails()
{
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public string Location { get; set; }

    public void RegisterEvent(EventDetails detail)
    {
        Console.WriteLine($"Event: {detail.EventName}, Date: {detail.EventDate}, Location: {detail.Location}");
    }
}

// Przykład użycia
class Program
{
    static void Main(string[] args)
    {
        var eventDetails = new EventDetails { EventName = "Konferencja", EventDate = new DateTime(2024, 12, 30), Location = "Warszawa" };
        eventDetails.RegisterEvent(eventDetails);
    }
}
