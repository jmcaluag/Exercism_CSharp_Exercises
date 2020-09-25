using System;

public static class Gigasecond
{
    // 10^9 = 1,000,000,000 (one billion)
    // Modified to use expression-bodied method.
    public static DateTime Add(DateTime moment) => moment.AddSeconds(Math.Pow(10, 9));
}