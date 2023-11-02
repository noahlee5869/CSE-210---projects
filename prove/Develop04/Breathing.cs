using System;
public class BreathingActivity : FullActivity
{

    public BreathingActivity()
    {
        SetActivityName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public override void StartActivity()
    {
        BreathingExercise();
    }

    public void BreathingExercise()
    {
        int breaths = (GetDuration() / 20) + 1;

        for (int i = 0; i < breaths; i++)
        {
            Console.Write($"Breath in...");
            UseTimer().CountDownFrom(4);
            Thread.Sleep(500);
            Console.WriteLine();
            Console.Write("Now breath out...");
            UseTimer().CountDownFrom(6);
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}