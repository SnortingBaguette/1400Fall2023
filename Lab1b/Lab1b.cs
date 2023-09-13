using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		DoMath(10, 4);  //Calling the Functions with values
		DoMath(20, 7);  //Calling the Functions with values
		DoMath(30, 15); //Calling the Functions with values
		Compare(4,3);   //Calling the Functions with values
		Compare(3,4);   //Calling the Functions with values
		CheckPassword("SevenOf9");  //Calling the Functions with values
		CheckPassword("OU812"); //Calling the Functions with values
		IsHealthCritical(76);   //Calling the Functions with values
		IsHealthCritical(43);   //Calling the Functions with values
		IsHealthCritical(1);    //Calling the Functions with values
	}
	
	static void DoMath (int value,int value2)   //Defining what the Function does
	{
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	static void Compare (int value,int value2)  //Defining what the Function does
	{
		if(value > value2) 
		{
			Console.WriteLine("True, the first one is greater.");
		}	else {
			Console.WriteLine("False, the second one is greater.");
		}
	}
	
	static void CheckPassword (string password)     //Defining what the Function does
	{
		if (password == "OU812") 
		{
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");
		}
	}
	
	static void IsHealthCritical (int healthAmount) {   //Defining what the Function does
		if(healthAmount > 50) {
			Console.WriteLine("Lots of health.");
		} else if (healthAmount >25 && healthAmount < 50) {
			Console.WriteLine("Medium Health");
		} else {
			Console.WriteLine("Health Critical!");
		}
	}
}