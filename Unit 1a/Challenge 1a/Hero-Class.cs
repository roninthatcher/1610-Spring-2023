using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
    public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
        heroThree = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
        heroOne.magic = 6;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 6;
		heroTwo.magic = 4;
        
        heroThree.health = 4;
        heroThree.powerLevel = 7;
		heroOne.magic = 2;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
        Console.WriteLine(heroOne.magic);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
        Console.WriteLine(heroTwo.magic);
		
		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
        Console.WriteLine(heroThree.magic);
	}
}

public class Hero 
    {
	public int health;
	public int powerLevel;
    public int magic;
}
