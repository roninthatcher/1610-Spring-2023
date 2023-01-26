using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 20;
      int y = 18;
      int z = 18;
      if (x > y) 
      {
        Console.WriteLine("Correct, the first is greater");
      }
      if (z == y) 
      {
        Console.WriteLine("Correct, they are equal");
      }
      
      int Health = 15;
      if (Health < 10) 
      {
        Console.WriteLine("Red");
      } 
      else if (Health < 20) 
      {
        Console.WriteLine("Yellow");
      } 
      else 
      {
        Console.WriteLine("Green");
        
      int time = 18;
      if (time == 18) 
      {
        Console.WriteLine("Correct");
      } 
      else 
      {
        Console.WriteLine("Incorrect");
      }
      int space = 45;
      if (space < 18) 
      {
        Console.WriteLine("Correct");
      } 
      else 
      {
        Console.WriteLine("Incorrect");
      }
        
      int target = 18;
      string result = (target == 18) ? "Got it!" : "You Missed";
      Console.WriteLine(result);
     }
    }
  }
 }
