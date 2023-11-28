// Base Class for all the events.
class Event
{
    // created the variables for the basic event.
    private string Name { get; set; }
    private DateTime Date { get; set; }
    private Address Location { get; set; }
    // Method for setting up the variables.
    public Event(string name, DateTime date, Address location)
    {
        Name = name;
        Date = date;
        Location = location;
    }
    // Method for printing the variables.
    public string GetEventDetails()
    {
        return $"'{Name}' on {Date.ToShortDateString()} at {Location.GetFullAddress()}";
    }

    // Method for the reminder about the event.
    public virtual string GetReminderMessage()
    {
        return $"Don't forget about the upcoming '{Name}' on {Date.ToShortDateString()}!";
    }

    // Method for printing a thank you message.
    public virtual string GetThankYouMessage()
    {
        return $"Thank you for attending '{Name}' on {Date.ToShortDateString()} at {Location.GetFullAddress()}. We hope to see you again!";
    }
}