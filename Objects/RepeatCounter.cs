using System;
using System.Collections.Generic;

namespace RepeatCounterProject.Objects
{
  public class RepeatCounter
  {
    public string CountRepeats(string userSentence, string wordToFind)
    {
      
      if (userSentence.Contains(wordToFind))
      {
        return "true";
      }
      else
      {
        return "word not found";
      }
    }
  }
}
