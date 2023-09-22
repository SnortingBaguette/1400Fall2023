using System;
					
public class Program
{
	public void Main()
	{

		weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon(), new weapon()};
		weaponsObjs[1].weaponName = "Railgun";
		weaponsObjs[1].baseDamage = 90;
		weaponsObjs[2].weaponName = "Lightning Gun";
		weaponsObjs[2].baseDamage = 6;
		weaponsObjs[3].weaponName = "Rocket Launcher";
		weaponsObjs[3].baseDamage = 100;
		
		
		foreach(var item in weaponsObjs)
		{
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.baseDamage + " damage per hit.");
		}
	}
		
		public class weapon 
		{
			public string weaponName = "Gauntlet";
			public int baseDamage = 75;
		}
}