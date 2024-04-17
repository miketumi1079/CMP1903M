using System;
using System.Diagnostics;

public class Testing
{
    public static void RunTests()
    {
        SevensOut sevensOutGame = new SevensOut(2);
        Debug.Assert(sevensOutGame != null, "SevensOut game object is null");

        ThreeOrMore threeOrMoreGame = new ThreeOrMore(5);
        Debug.Assert(threeOrMoreGame != null, "ThreeOrMore game object is null");
    }
}