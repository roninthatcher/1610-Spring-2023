using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("DICE ROLL MINIGAME!");
      Random DiceRoll = new Random();
      
      int roll = 0;
      int attempts = 0;
      
      while (roll != 6) 
      {
        roll = DiceRoll.Next(1, 7);
        Console.WriteLine("You Rolled:" + roll);
        attempts++;
      }
      Console.WriteLine("It took you " + attempts + " attempts to roll a 6");
      int rupees = attempts * 5;
      Console.WriteLine("That'll be " + rupees + " rupees if you want the prize.");
    }
  }
}
