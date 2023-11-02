using System;


class Program
{
    static void Main(string[] args)
    {
        MainMenu main = new MainMenu();
        string input = main.OptionsDisplay();

        while (input != "4")
        {
            FullActivity activity = main.PickActivity(input);

            activity.ActivitySetup();

            activity.StartActivity();

            activity.FinishActivity();

            input = main.OptionsDisplay();

        }
    }
}