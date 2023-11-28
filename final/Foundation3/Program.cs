using System;

class Program
{
    static void Main(string[] args)
    {
        // Calls all the different classes with the various messages.
        
        Address eventAddress = new Address("315", "Kalispell", "MT", "USA");

        Event genericEvent = new Event("Florida Panthers Hockey Game", DateTime.Now.AddDays(30), eventAddress);
        Concert concertEvent = new Concert("The Complex", DateTime.Now.AddDays(50), eventAddress, "The Chats");
        Seminar seminarEvent = new Seminar("Put God First", DateTime.Now.AddDays(30), eventAddress, "Denzel Washington");
        Wedding weddingEvent = new Wedding("Ashton and shawndra", DateTime.Now.AddDays(20), eventAddress, "The Tavern");

        Console.WriteLine("List of Events:");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(genericEvent.GetReminderMessage());
        Console.WriteLine(genericEvent.GetThankYouMessage());
        Console.WriteLine("----------------------------------");

        Console.WriteLine(concertEvent.GetReminderMessage());
        Console.WriteLine(concertEvent.GetThankYouMessage());
        Console.WriteLine("----------------------------------");

        Console.WriteLine(seminarEvent.GetReminderMessage());
        Console.WriteLine(seminarEvent.GetThankYouMessage());
        Console.WriteLine("----------------------------------");

        Console.WriteLine(weddingEvent.GetReminderMessage());
        Console.WriteLine(weddingEvent.GetThankYouMessage());
        Console.WriteLine(weddingEvent.GetAnnouncementMessage());
    }
}