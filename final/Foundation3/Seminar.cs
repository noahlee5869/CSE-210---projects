class Seminar : Event
{
    // Created a variable for the speaker of the event.
    private string Orator { get; set; }

    // Method for setting the variable of a orator
    public Seminar(string name, DateTime date, Address location, string orator) 
        : base(name, date, location)
    {
        Orator = orator;
    }

    // Method for printing a thank you message.
    public override string GetThankYouMessage()
    {
        return $"Thank you for coming to the seminar by {Orator} at {base.GetEventDetails()}. We hope you learned alot!";
    }
}