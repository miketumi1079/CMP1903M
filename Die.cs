using System;

public class Die
{
    private Random random;
    public int FaceValue { get; private set; }

    public Die()
    {
        random = new Random();
        FaceValue = 1;
    }

    public int Roll()
    {
        FaceValue = random.Next(1, 7);
        return FaceValue;
    }
}