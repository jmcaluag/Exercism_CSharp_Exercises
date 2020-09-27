
using System;

public static class ResistorColor
{
    public static string[] colorCode =  {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    public static string[] Colors()
    {
        return colorCode;
    }
}