using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int Score = -29;
      switch (Score) 
      {
        case 1:
          Console.WriteLine("Miss");
          break;
        case 2:
          Console.WriteLine("Okay");
          break;
        case 3:
          Console.WriteLine("Good");
          break;
        case 4:
          Console.WriteLine("Great");
          break;
        case 5:
          Console.WriteLine("Amazing");
          break;
        case 6:
          Console.WriteLine("Outstanding");
          break;
        case 7:
          Console.WriteLine("Perfect!");
          break;
        default:
          Console.WriteLine("");
          break;
      }    
    }
  }
}
