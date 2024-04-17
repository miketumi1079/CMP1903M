using System;

public class Program
{
    public static void Main(string[] args)
    {
        Statistics stats = new Statistics();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Play Sevens Out");
            Console.WriteLine("2. Play Three or More");
            Console.WriteLine("3. View Statistics");
            Console.WriteLine("4. Run Tests");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SevensOut sevensOutGame = new SevensOut(2);
                    sevensOutGame.Play();
                    stats.UpdateStats("Sevens Out", sevensOutGame.score);
                    break;
                case "2":
                    ThreeOrMore threeOrMoreGame = new ThreeOrMore(5);
                    threeOrMoreGame.Play();
                    stats.UpdateStats("Three or More", threeOrMoreGame.score);
                    break;
                case "3":
                    stats.DisplayStats();
                    break;
                case "4":
                    Testing.RunTests();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}