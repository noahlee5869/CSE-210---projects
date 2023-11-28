class Concert : Event
{
    // Created a variable for MainEvent.
    private string MainEvent { get; set; }
    
    // Method for Overriding the Reminder Message.
    public override string GetReminderMessage()
    {
        return $"Get ready for an amazing concert! {MainEvent} will be performing at {base.GetEventDetails()}.";
    }
    // Method for printing the concert information.
    public Concert(string name, DateTime date, Address location, string mainevent) 
        : base(name, date, location)
    {
        MainEvent = mainevent;
    }
}