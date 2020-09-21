public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.

    // Uses optional parameters. TwoFer prime refines this and turns it into a single-body method using lambda expression.
    public static string Speak(string name = "you")
    {
        return $"One for {name}, one for me.";
    }
}