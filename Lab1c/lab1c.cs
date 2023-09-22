using System;
					
public class Program
{
	public void Main()
	{
		Console.Write("Enter a number: ");
		int enteredNumber = Convert.ToInt16(Console.ReadLine()); //Converts the input into a number
		int row = 0;
		for(int i = 1; i <= enteredNumber; i++) //Runs the loop while the i is less than the entered number
		{
			while (row < i) //Runs the loop while the row number is less than i
			{
				Console.Write(i); //Keeps writing i on the same string. I used WriteLine previously, and it was giving me a wrong result
				row++; //Counts the row number so it doesn't go over i
			}
			Console.WriteLine(""); //Moves on to the next row so it would look like a pyramid
			row = 0; //Resets the row value so it can be used again
		} 
	}
}
