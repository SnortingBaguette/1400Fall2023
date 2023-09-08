using System;

public class Program
{
    public static void Main()
    {
        string name;                     //Initializing the Variables
        int mathAnswer;                  //Initializing the Variables
        char answerYesNo;                //Initializing the Variables
        bool likedTheJoke;               //Initializing the Variables
        double doubleQuestion;           //Initializing the Variables

        Console.WriteLine("Initializing the Start Up Sequence... OK \nChecking GPU for Mining Capabilities ... OK \nPress Enter To Continue");   //Sending text on screen
        Console.ReadLine();        //Waiting for input
        Console.WriteLine("What's your name?");
        name = Console.ReadLine();        //Saving input as a variable
        Console.WriteLine("Yeah, I'll remember that.");
        Console.WriteLine("Wanna Hear a Joke?\nY/N");
        answerYesNo = Convert.ToChar(Console.ReadLine());        //Converting the input from user to character
        if (char.ToUpper(answerYesNo) == 'Y')        //Capitalizing the input
        {
            Console.WriteLine("How many developers does it take to screw in a lightbulb?\nNone. It’s a hardware problem. \nHAHAHAHAHAHA \nBy the way, what's 9 + 10?");
            likedTheJoke = true;        //Saving the joke status
        }
        else
        {
            Console.WriteLine("Ugh, you're boring. I bet you'd be up for doing some math right now. What's 9 + 10?");
            likedTheJoke = false;        //Saving the joke status
            
        }

        mathAnswer = Convert.ToInt32(Console.ReadLine());        //Recording the answer

        
        if (mathAnswer == 21)        //Comparing the values
        {
            Console.WriteLine("You stoopid");
        } 
        else if (mathAnswer == 19)         //Comparing the values
        {
            Console.WriteLine("Welp, math nerd.");
        }
        else        //If none are checking out, use this part
        {
            Console.WriteLine("Wrong. Not only you're boring, you're also not very bright, huh?");
        }

        if (likedTheJoke)        //Comparing joke status
        {
            Console.WriteLine("Well, at least you liked the joke");
        }
        else 
        { 
            Console.WriteLine("You didn't even like my amazing joke.");
        }

        Console.WriteLine("What's 7/2?");        
        doubleQuestion = Convert.ToDouble(Console.ReadLine());        //Coverting the answer to float value
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
