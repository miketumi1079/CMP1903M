using System;

public abstract class Game
{
    protected Die[] dice;
    protected internal int score; // Change access level to protected internal

    public abstract void Play();
}