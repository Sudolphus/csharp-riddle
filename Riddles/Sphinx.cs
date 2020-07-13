using System.Collections.Generic;

namespace Riddle.SphinxRiddler
{
  public class Sphinx
  {
    public string Answer { get; set; }

    private Dictionary<int, string> riddleQuestions = new Dictionary<int, string>() { {0, "What has 4 legs in the morning, 2 legs in the afternoon, and 3 legs at night?"} };

    private Dictionary<int, string> riddleAnswers = new Dictionary<int, string>() { {0, "A person"} };

    public string AskRiddle()
    {
      string riddle = riddleQuestions[0];
      string answer = riddleAnswers[0];
      Answer = answer;
      return riddle;
    }
  }
}