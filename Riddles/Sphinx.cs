namespace Riddle.SphinxRiddler
{
  public class Sphinx
  {
    public string Answer { get; set; }

    public string AskRiddle()
    {
      string riddle = "What has 4 legs in the morning, 2 legs in the afternoon, and 3 legs at night?";
      string answer = "A person";
      Answer = answer;
      return riddle;
    }
  }
}