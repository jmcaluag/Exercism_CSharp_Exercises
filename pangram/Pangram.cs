using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        List<char> letters = new List<char>();

        foreach (char character in input.ToLower())
        {
            //ASCII lowercase alphabet from 97 to 122
            if(character > 96 && character < 123 && !letters.Contains(character))
            {
                letters.Add(character);
            }
        }

        return letters.Count == 26;
    }
}
