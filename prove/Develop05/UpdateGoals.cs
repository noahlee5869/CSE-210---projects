using System.Drawing;

class UpdateGoals : Base
{
    public string userInput;
    private string ThirdItem;
    public void AddPoints()
    {
        Console.WriteLine("Which goal did you complete?");
        userInput = Console.ReadLine();
//        if (userInput == GoalName)
//        {
//            ThirdItem = GoalList[2];
//            if (int.TryParse(ThirdItem, out int ThirdItemAsInt))
//        {
//            Console.WriteLine(ThirdItemAsInt);
//        }
//        else
//        {
//            Console.WriteLine("Unable to convert the third item to an integer.");
//        }
//            PointTotal = PointTotal + ThirdItem;
//        }
        Console.WriteLine("Your total score is: ");
        Console.WriteLine(PointTotal);
    }
}