using System;

namespace Code2Test;

public class Program
{
    public static void Main(string[] args)
    {
        int timeOfDay = 21;
        string greeting;
        greeting = Greeting(timeOfDay);
        Console.WriteLine(greeting);
    }

    public static string Greeting(int time)
    {
        if (time < 0 || time > 24)
            throw new ArgumentOutOfRangeException($"{time} is out of range. Please type value between 0 & 24 Inclusive");
        else if (time >= 5 && time < 12)
            return "Good Morning";
        else if (time >= 12 && time <= 18)
            return "Good Afternoon";
        else
            return "Good Evening";
    }

    public static string GreetingV2(int time)
    {
        String greeting;

        if (time >= 5 && time <= 12)
            greeting = "Good Morning";
        else if (time >= 12 && time <= 18)
            greeting = "Good Afternoon";
        else
            greeting = "Good Evening";

        return greeting;
    }

    // for age classifications (not normally placed in same file)
    public static string AvailableClassifications(int ageOfViewer)
    {
        if (ageOfViewer < 0 || ageOfViewer > 150)
            throw new ArgumentOutOfRangeException($"{ageOfViewer} is not within valid range. Please enter age between 0 & 150 Inclusive");
        else if (ageOfViewer < 12)
            return "U, PG & 12 films are available.";
        else if (ageOfViewer < 15)
            return "U, PG, 12 & 15 films are available.";
        else
            return "All films are available.";
    }

    // pg = age 8 & up (but this is guidance only so will be ignored)
    // 12 = age 12 & up
    // 12A = any age with ADULT
    // 15 = age 15 & up
    // 18 = ALL

    public static string CorrectedClassifications(int ageOfViewer, bool withAdult)
    {
        if (ageOfViewer < 0 || ageOfViewer > 150)
            throw new ArgumentOutOfRangeException($"{ageOfViewer} is not within valid range. Please enter age between 0 & 150 Inclusive");
        if (withAdult)
        {
            if (ageOfViewer < 15)
                return "U, PG & 12 films are available.";
            else if (ageOfViewer < 18)
                return "U, PG, 12 & 15 films are available.";
            else
                return "All films are available.";
        }
        else
        {
            if (ageOfViewer < 12)
                return "U & PG films are available.";
            else if (ageOfViewer < 15)
                return "U, PG & 12 films are available.";
            else if (ageOfViewer < 18)
                return "U, PG, 12 & 15 films are available.";
            else
                return "All films are available.";
        }
    }

    // edited version to remove redundant lines of code (as adult supervision only affects
    // the 12A certificate movies (which we will just write as 12, as 12A is a cinema
    // exclusive which is EXACTLY THE SAME AS A 12 CERTIFICATE.
    public static string AltClassification(int ageOfViewer, bool withAdult)
    {
        if (ageOfViewer < 0 || ageOfViewer > 150)
            throw new ArgumentOutOfRangeException($"{ageOfViewer} is not within valid range. Please enter age between 0 & 150 Inclusive");
        else if (ageOfViewer < 12)
        {
            if (withAdult)
                return "U, PG & 12 films are available.";
            else
                return "U & PG films are available.";
        }
        else if (ageOfViewer < 15)
            return "U, PG & 12 films are available.";
        else if (ageOfViewer < 18)
            return "U, PG, 12 & 15 films are available.";
        else
            return "All films are available.";
    }
}