using System;

public class SevensOut : Game
{
    public SevensOut(int numDice)
    {
        dice = new Die[numDice];
        for (int i = 0; i < numDice; i++)
        {
            dice[i] = new Die();
        }
    }

    public override void Play()
    {
        Console.WriteLine("Playing Sevens Out...");
        int total = 0;
        while (true)
        {
            int roll1 = dice[0].Roll();
            int roll2 = dice[1].Roll();
            int sum = roll1 + roll2;
            Console.WriteLine($"Rolled: {roll1}, {roll2} - Total: {sum}");
            if (sum == 7)
            {
                Console.WriteLine("You hit 7! Game over.");
                break;
            }
            else
            {
                total += sum;
                Console.WriteLine($"Current total: {total}");
            }
        }
        score = total;
    }
}