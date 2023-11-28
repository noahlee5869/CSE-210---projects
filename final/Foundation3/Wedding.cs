class Wedding : Event
{
    // Created variable for the people getting married.
    private string People { get; set; }

    // Method setting the variable of people.
    public Wedding(string name, DateTime date, Address location, string people) 
        : base(name, date, location)
    {
        People = people;
    }

    // Method for printing the Announcement message.
    public string GetAnnouncementMessage()
    {
        return $"We are excited to announce the wedding of {People} at {base.GetEventDetails()}!";
    }
}