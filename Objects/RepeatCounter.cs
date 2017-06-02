using System;
using System.Collections.Generic;

namespace RepeatCounterProject.Objects
{
  public class RepeatCounter
  {
    public string CountRepeats(string userSentence, string wordToFind)
    {
      int counter = 0;
      string[] words = userSentence.Split(' ');
      foreach (string word in words)
      if (word == wordToFind)
      {
        counter += 1;
      }
      return counter.ToString();
    }
  }
}
