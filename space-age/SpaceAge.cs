using System;

public class SpaceAge
{

    private const double earthYearInSeconds = 1 / 31557600d;
    
    // 1 Year in planet in relation to Earth years.
    // Example: 1 Mercury Year = 0.2408467 Earth years.
    private const double mercuryYearAsEarth = 0.2408467;
    private const double venusYearAsEarth = 0.61519726;
    private const double marsYearAsEarth = 1.8808158;
    private const double jupiterYearAsEarth = 11.862615;
    private const double saturnYearAsEarth = 29.447498;
    private const double uranusYearAsEarth = 84.016846;
    private const double neptuneYearAsEarth = 164.79132;

    public int ageInSeconds;

    public SpaceAge(int seconds)
    {
         ageInSeconds = seconds;
    }

    // calculateOnEarth() created to avoid rounding errors when used for other planets.
    public double calculateOnEarth()
    {
        return earthYearInSeconds * this.ageInSeconds;
    }

    public double OnEarth()
    {
        return Math.Round(calculateOnEarth(), 2);
    }

    public double OnMercury()
    {
        return Math.Round(calculateOnEarth() / mercuryYearAsEarth, 2);
    }

    public double OnVenus()
    {
        return Math.Round(calculateOnEarth() / venusYearAsEarth, 2);
    }

    public double OnMars()
    {
        return Math.Round(calculateOnEarth() / marsYearAsEarth, 2);
    }

    public double OnJupiter()
    {
        return Math.Round(calculateOnEarth() / jupiterYearAsEarth, 2);
    }

    public double OnSaturn()
    {
        return Math.Round(calculateOnEarth() / saturnYearAsEarth, 2);
    }

    public double OnUranus()
    {
        return Math.Round(calculateOnEarth() / uranusYearAsEarth, 2);
    }

    public double OnNeptune()
    {
        return Math.Round(calculateOnEarth() / neptuneYearAsEarth, 2);
    }
}