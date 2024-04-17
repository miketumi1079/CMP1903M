using System;
using System.Collections.Generic;

public class Statistics
{
    private Dictionary<string, int> gameStats;

    public Statistics()
    {
        gameStats = new Dictionary<string, int>();
    }

    public void UpdateStats(string gameType, int score)
    {
        if (!gameStats.ContainsKey(gameType))
        {
            gameStats.Add(gameType, score);
        }
        else
        {
            gameStats[gameType] = score;
        }
    }

    public void DisplayStats()
    {
        Console.WriteLine("Game Statistics:");
        foreach (var entry in gameStats)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}