using System;
					
public class Program
{
	public static void Main()
	{
    	int num1 = 10; //Created an integer
    	int num2 = 5; //Created a second integer
		int num3 = 3; //Created a third integer
    	float float1 = 5.4f; //Created a float
    	char character1 = 'C'; //Created a character
    	bool bool1 = true; //Created a boolean
    	string newString = "The answer is letter "; //Created a string
	
		Console.WriteLine(num1 + num2); //Adding two numbers
   	 	Console.WriteLine(num1 - num2); //Subtracting two numbers
		Console.WriteLine(num1 * num2); //Multiplying two numbers
		Console.WriteLine(num1 / num2); //Dividing two numbers
		Console.WriteLine(num1 % num3); //Return the division remainder
		Console.WriteLine(num1 ++); //Incrementally add one
		Console.WriteLine(num1 --); //Incrementally subtract one
		Console.WriteLine(float1 / 2); //Divide a float
		Console.WriteLine(newString + character1); //Concatenation
		Console.WriteLine(num1 == num2); //Compare two numbers
		Console.WriteLine(num1 != num2); //Compare two numbers
		Console.WriteLine(num1 > num2); //Compare two numbers
		Console.WriteLine(num1 < num2); //Compare two numbers
		Console.WriteLine(num1 >= num2); //Compare two numbers
		Console.WriteLine(num1 <= num2); //Compare two numbers
		Console.WriteLine(bool1 && num1 > num2); //If both are true, will display true
		Console.WriteLine(bool1 || num2 > num1); //If one is true, will display true
		Console.WriteLine(!(bool1 || num2 > num1)); //Inverts the bool statement
	}
}