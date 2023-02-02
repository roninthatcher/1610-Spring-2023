using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hey Hero! Got some neat gear for ya!");
      
      string[] Gear = {"Sword (400 rupees)", ">Arrows (20 rupees)", "Bombs (30 rupees)", "Rope (10 rupees)"};
      foreach (string i in Gear) 
      {
        Console.WriteLine(i);
      }   
      
      Console.WriteLine("");
      Console.WriteLine("My my what a pretty face, doesn't get you a discount honey.");
      
       string[] Magic = {"Potion (5 rupees)", "Spell Book (50 rupees)", "Charms (30 rupees)", ">Mask (15 rupees)"};
       Magic[2] = "Sold Out";
      foreach (string i in Magic) 
      {
        Console.WriteLine(i);
      } 
      
       
      Console.WriteLine("");
      Console.WriteLine("ZZZZzzzzZZz- Huh? ...Shop? Oh yeah, that's what I do.");
      
       string[] Garbage = {"Bannana Peel (0 rupees)", "Crinkled Paper (0 rupees)", ">Sludge (-1 rupee)", "Corn? (90 rupees)"};
       Garbage[0] = "You don't have enough courage to buy this.";
      foreach (string i in Garbage) 
      {
        Console.WriteLine(i);
      } 
    }
  }
}
