using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Who is your favorite Mario characters?");
      string[] characters = new string[10];
      
      characters[0] = Console.ReadLine();
      characters[1] = Console.ReadLine();
      characters[2] = Console.ReadLine();
      characters[3] = Console.ReadLine();
      characters[4] = Console.ReadLine();
      characters[5] = Console.ReadLine();
      characters[6] = Console.ReadLine();
      characters[7] = Console.ReadLine();
      characters[8] = Console.ReadLine();
      characters[9] = Console.ReadLine();
      
      Array.Sort(characters);
      
      for (int i = 0; i < characters.Length; i++) 
      {
        Console.WriteLine(characters[i]);
      }
      
      Console.WriteLine("\nHere are some popular picks");
      string[] popular = {"Luigi", "Yoshi", "Waluigi", "Rosalina"};
      for (int i = 0; i < popular.Length; i++) 
      {
        Console.WriteLine(popular[i]);
        Array.Sort(popular);
      }
    }
  }
}
