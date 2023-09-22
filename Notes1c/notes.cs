using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Mustang", "Camero", "Hellcat", "Corvette", "Viper", "McClaren"};
		foreach (var car in cars)
		{
			Console.WriteLine("I love my " +car+".");
		}
		
		
		string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
		for (var i = 0; i < playerTypes.Length; i++)
		{
			playerTypes[i] = "Queen";
		}
		foreach (var playerType in playerTypes)
		{
			Console.WriteLine(playerType);
		}
		
		
		weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon(), new weapon()};
		weaponsObjs[1].weaponName = "Railgun";
		weaponsObjs[2].weaponName = "Lightning Gun";
		weaponsObjs[3].weaponName = "Rocket Launcher";
		
		for(var i = 0; i < weaponsObjs.Length; i++)
		{
			weaponsObjs[i].powerLevel = 2;
		}
		
		foreach(var item in weaponsObjs)
		{
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.powerLevel);
		}
	}
}