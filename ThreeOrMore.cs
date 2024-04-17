using System;

public class ThreeOrMore : Game
{
    public ThreeOrMore(int numDice)
    {
        dice = new Die[numDice];
        for (int i = 0; i < numDice; i++)
        {
            dice[i] = new Die();
        }
    }

    public override void Play()
    {
        Console.WriteLine("Playing Three or More...");
        int total = 0;
        while (total < 20)
        {
            int[] rolls = new int[dice.Length];
            for (int i = 0; i < dice.Length; i++)
            {
                rolls[i] = dice[i].Roll();
                Console.WriteLine($"Die {i + 1}: {rolls[i]}");
            }

            Array.Sort(rolls);
            int count = 1;
            for (int i = 1; i < rolls.Length; i++)
            {
                if (rolls[i] == rolls[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count >= 3)
                {
                    int points = count == 3 ? 3 : count == 4 ? 6 : 12;
                    total += points;
                    Console.WriteLine($"You got {count}-of-a-kind! Points: {points}, Total: {total}");
                    break;
                }
            }

            if (total >= 20)
            {
                Console.WriteLine("You reached 20 points! Game over.");
                break;
            }

            Console.WriteLine("No scoring combination, rerolling...");
        }

        score = total;
    }
}