# Engineering120DC

This repository has been created for the purposes of storing relevant programming related work that will be done during my training for Sparta Global.

Each week will have their own README markdown file, that allows the reader to understand what I have done in that week.

## Week 1 - Induction Week

###### Overview

This week covered the basics of the use of Markdown, Windows PowerShell (though I used a Macintosh for this), Visual Studio, Powershell Scripting, Git, GitHub & very basic C#. At the end of the week, Agile and Scrum was covered, including scrum related techniques. 

###### Included work

C# Introduction project, that prints something sent to the console.

## Week 2 - C# Fundamentals

###### Overview

Text goes here!

###### Included work

The C# Example shown in the class tutorial lesson, the test cases of that program, the lab task code & test cases used for testing that lab code

## Week 3 - Object-Oriented Programming

###### Overview

Text goes here!

###### Included work

Text goes here!

## Week 4 - Advanced OOP & Data

###### Overview

Text goes here!

###### Included work

Text goes here!

## Week 5 - ISTQB

###### Overview

Text goes here!

###### Included work

Text goes here!

## Week 6 - Advanced C# & Testing

###### Overview

Text goes here!

###### Included work

Text goes here!

## Week 7 - Web Testing

###### Overview

Text goes here! 

###### Included work

Text goes here!

## Week 8 - Project

###### Overview

Text goes here!

###### Included work

Text goes here!

using System;

namespace CSharpIntro;

public class Program
{
    public static void Main(string[] args)
    {
        /*int x = 100;
        x += 10;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            x += i;
        }*/

        Console.WriteLine("Writing our command line arguments");
        foreach (string item in args)
        {
            Console.WriteLine(item);
        }
    }
}


