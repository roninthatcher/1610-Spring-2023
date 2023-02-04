
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What would you like to craft?");
      string[] materials = {"Wood", ">Stone", "Iron", "Charm"};
      foreach (string i in materials) 
      {
        Console.WriteLine(i);
      } 
      
      Console.WriteLine("What you could make:");
      string[] recipes = {"Stone Axe (Wood + Stone)", "Magic Stone (Enchantment + Stone", "Iron Spell Caster (Iron + Enchantment)"};
      foreach (string i in recipes) 
      {
        Console.WriteLine(i);
      } 
    }
  }
}
