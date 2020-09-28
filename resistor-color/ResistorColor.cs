
using System;

public static class ResistorColor
{
    // This is a more concise way of writing this program without having to recreate the colorCode array every time it is run.
    // Uncomment Colors() method and change IndexOf parameter to run for unit tests.
    private static string[] colorCode =  {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    public static int ColorCode(string color) => Array.IndexOf(colorCode, color); // Change to Colors() to use the method.

    // Use to fulfill unit tests.

    // public static string[] Colors()
    // {
    //     return colorCode;
    // }
}