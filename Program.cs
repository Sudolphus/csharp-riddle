using System;
using Riddle.SphinxRiddler;

namespace Riddle
{
  public class Riddle
  {
    public static void Main()
    {
      Console.WriteLine("Answer the following riddle or else.");
      Sphinx Riddler = new Sphinx();
      string askRiddle = Riddler.AskRiddle();

      Console.WriteLine(askRiddle);

      string riddleAnswer = Console.ReadLine();

      if (riddleAnswer == Riddler.Answer) 
      {
        Console.WriteLine("Your answer was correct!");
        Main();
      }
      else
      {
        Console.WriteLine("Sorry, your answer was incorrect.");
      }  
    }
  }
}