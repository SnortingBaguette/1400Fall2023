using System;
					
public class Program
{
	public static void Main()
	{
		//challenge1
		
		Random rnd = new Random();
		int num = rnd.Next(1,10);		//For some reason it generates a new number after each input?
		int numberGenerated = num;		//I tried to work around that by assigning the initial generated value to a different variable, but it's being updated after each input as well?
		Console.WriteLine("I have generated a number between 1 and 10. You have 5 guesses.");
		Console.WriteLine(numberGenerated);	//Writing the generated number into console for the debugging. It updates after each new input in "for" loop.
		for(int i = 4; i >= 0; i--)	//Creating an i variable that will represent the amount of guesses left.
		{
			int numInput = Convert.ToInt16(Console.ReadLine());	//Reading the input
			if (numInput > numberGenerated)	//Comparing the input to the initial value
			{
				Console.WriteLine("Wrong, the number I generated is lower than that. You have " + i + " attempts left.");
			}
			else if (numInput < numberGenerated)	//Comparing the input to the initial value
			{
				Console.WriteLine("Wrong, the number I generated is bigger than that. You have " + i + " attempts left.");
			} 
			else 
			{
				Console.WriteLine("That's correct!");	//Comparing the input to the initial value
				break;
			}
		}
		
		
		//challenge 2
		
		Console.WriteLine("Name your favorite food #1:"); 
		string food1 = Console.ReadLine();	//Create the first food
		Console.WriteLine("Name your favorite food #2:");
		string food2 = Console.ReadLine();	//Create the second food
		Console.WriteLine("Name your favorite food #3:");
		string food3 = Console.ReadLine();	//Create the third food
		string[] foods = {food1, food2, food3};	//Create an array with the foods
		foreach (string i in foods)	//Go through the array and print out the foods with extra text
		{
			Console.WriteLine("I love " + i + "!");
		}
	}
}