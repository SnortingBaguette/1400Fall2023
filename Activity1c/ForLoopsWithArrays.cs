using System;
					
public class Program
{
	public void Main()
	{
		string[] healthMessage = {"Full Health", "Almost Full Health", "Medium Health", "Critical Health"};
		int health = 50;
		for(int i = 0; i < 4; i++)
		{
			health -= 10;
			Console.WriteLine(health);
			Console.WriteLine(healthMessage[i]);
		}
	}
}