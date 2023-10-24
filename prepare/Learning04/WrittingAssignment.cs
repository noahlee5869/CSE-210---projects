public class WrittingAssignment : Assignment
{
    private string Title1;

    public WrittingAssignment(string StudentName, string Topic, string Title) : base (StudentName, Topic)
    {
        Title1 = Title;
    }

    public string GetWrittingInformation()
    {
        return Title1;
    }
}