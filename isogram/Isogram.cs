using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> letters = new List<char>();

        foreach (char character in word.ToLower())
        {
            // ASCII lowercase alphabet from 97 to 122
            // ASCII value 32 and 45 are space and dash, respectively.
            if(character > 96 && character < 123 && !letters.Contains(character) || (character == 32 || character == 45))
            {
                letters.Add(character);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
