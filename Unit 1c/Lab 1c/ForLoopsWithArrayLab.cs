using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] Starter = {"Bulbasaur", "Charmander", "Squirtle"};
      for (int i = 0; i < Starter.Length; i++) 
      {
        Console.WriteLine(Starter[i]);
      }
      
      string[] Rare = {"Gengar", "Alazazam", "Dragonite"};
      Rare[1] = "Snorlax";
      for (int v = 0; v < Rare.Length; v++) 
      {
        Console.WriteLine(Rare[v]);
      }
      
      string[] Legend = {"Articuno", "Zapdos", "Moltress"};
      for (int l = 2; l < Legend.Length; l++) 
      {
        Console.WriteLine(Legend[l]);
      }
    }
  }
}
