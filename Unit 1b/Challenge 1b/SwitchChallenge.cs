using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int BaseStrength = 30;
      int PowerGlove = 10;
      int Strength = BaseStrength + PowerGlove;
      int ItemWeight = 40;
      if (ItemWeight < Strength) 
      {
        Console.WriteLine("This Item can be picked up");
      } 
      else if (ItemWeight == Strength)
      {
        Console.WriteLine("This Item is pretty heavy, be careful");
      }
      else
      {
        Console.WriteLine("This Item is too heavy");
      }
       int StrengthPotion = 4;
      switch (StrengthPotion) 
      {
        case 1:
          Console.WriteLine("You have Strength Potion equipped, Drinking it gives you +10 strength for 10 minutes");
          break;
        case 2:
          Console.WriteLine("You have Strength Potion 2 equipped, Drinking it gives you +20 strength for 10 minutes");
          break;
        case 3:
          Console.WriteLine("You have Strength Potion 3 equipped, Drinking it gives you +30 strength for 20 minutes");
          break;
        case 4:
          Console.WriteLine("You have Strength Potion 4 equipped, Drinking it gives you +40 strength for 20 minutes");
          break;
        case 5:
          Console.WriteLine("You have Strength Potion 5 equipped, Drinking it gives you +50 strength for 30 minutes");
          break;
      }
      string result = (ItemWeight <= Strength) ? "Press A to pick up" : "Can't pick up.";
      Console.WriteLine(result);
    }
  }
}
