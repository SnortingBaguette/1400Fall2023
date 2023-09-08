using System;

public class Program
{
    public static void Main()
    {
        string name;
        int mathAnswer;
        char answerYesNo;
        bool likedTheJoke;
        double doubleQuestion;

        Console.WriteLine("Initializing the Start Up Sequence... OK \nChecking GPU for Mining Capabilities ... OK \nPress Enter To Continue");
        Console.ReadLine();
        Console.WriteLine("What's your name?");
        name = Console.ReadLine();
        Console.WriteLine("Yeah, I'll remember that.");
        Console.WriteLine("Wanna Hear a Joke?\nY/N");
        answerYesNo = Convert.ToChar(Console.ReadLine());
        if (char.ToUpper(answerYesNo) == 'Y')
        {
            Console.WriteLine("How many developers does it take to screw in a lightbulb?\nNone. It’s a hardware problem. \nHAHAHAHAHAHA \nBy the way, what's 9 + 10?");
            likedTheJoke = true;
        }
        else
        {
            Console.WriteLine("Ugh, you're boring. I bet you'd be up for doing some math right now. What's 9 + 10?");
            likedTheJoke = false;
            
        }

        mathAnswer = Convert.ToInt32(Console.ReadLine());

        
        if (mathAnswer == 21) 
        {
            Console.WriteLine("You stoopid");
        } 
        else if (mathAnswer == 19) 
        {
            Console.WriteLine("Welp, math nerd.");
        }
        else
        {
            Console.WriteLine("Wrong. Not only you're boring, you're also not very bright, huh?");
        }

        if (likedTheJoke)
        {
            Console.WriteLine("Well, at least you liked the joke");
        }
        else 
        { 
            Console.WriteLine("You didn't even like my amazing joke.");
        }

        Console.WriteLine("What's 7/2?");
        doubleQuestion = Convert.ToDouble(Console.ReadLine());
        if(doubleQuestion == 3.5)
        {
            Console.WriteLine("Yep, " + name + "\'s a nerd.");
        }
        else
        {
            Console.WriteLine(name + ", bruh.");
        }
    }
}