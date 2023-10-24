public class MathAssignment : Assignment
{

    private string TextBookSection1;
    private string Problems1;

    public MathAssignment(string StudentName, string Topic, string TextBookSection, string Problems) : base (StudentName, Topic)
    {
        TextBookSection1 = TextBookSection;
        Problems1 = Problems;
    }

    public string GetHomeworkList()
    {
        return $"section {TextBookSection1} Problems {Problems1}";
    }

}