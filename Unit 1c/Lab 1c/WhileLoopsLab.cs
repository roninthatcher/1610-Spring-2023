using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Levels until new ability");
      int Level = 10;
      do
      {
        Console.WriteLine(Level);
        Level++;
      }
      while (Level < 20);
      int exp = 200;
      int left = 1500 - exp;
      if (exp < 1500);
      {
        Console.WriteLine("You need " + left + " exp to reach the next level");
      }
    }
  }
}
