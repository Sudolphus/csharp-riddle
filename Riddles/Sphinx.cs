using System;
using System.Collections.Generic;

namespace Riddle.SphinxRiddler
{
  public class Sphinx
  {
    public string Answer { get; set; }

    private Dictionary<int, string> riddleQuestions = new Dictionary<int, string>() { {0, "What has 4 legs in the morning, 2 legs in the afternoon, and 3 legs at night?"}, {1, "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?"}, {2, "What can you keep after giving to someone?"} };

    private Dictionary<int, string> riddleAnswers = new Dictionary<int, string>() { {0, "A person"}, {1, "Fire"}, {2, "Your word"} };

    public string AskRiddle()
    {
      int nextRiddle = GetRandom();
      string riddle = riddleQuestions[nextRiddle];
      string answer = riddleAnswers[nextRiddle];
      Answer = answer;
      return riddle;
    }

    private int GetRandom()
    {
      Random rnd = new Random();
      return rnd.Next(0, 3);
    }
  }
}