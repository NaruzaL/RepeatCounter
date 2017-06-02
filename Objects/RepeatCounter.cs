using System;
using System.Collections.Generic;

namespace RepeatCounterProject.Objects
{
  public class RepeatCounter
  {
    public string CountRepeats(string userSentence, string wordToFind)
    {
      int counter = 0;
      if (userSentence.Contains(wordToFind))
      {
        counter += 1;
      }
      else
      {
        return "word not found";
      }
      return counter.ToString();
    }
  }
}
