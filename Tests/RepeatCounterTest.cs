using Xunit;
using System;
using System.Collections.Generic;
using RepeatCounterProject.Objects;

namespace RepeatCounterTest
{
  public class ReapeatCounterTest
  {
    [Fact]
    public void FindUserChosenWordInUserSentence_True()
    {
      RepeatCounter newInstance = new RepeatCounter();
      Assert.Equal("1", newInstance.CountRepeats("is", "is"));
    }
    [Fact]
    public void CountFirstInstanceOfChosenWord_1()
    {
      RepeatCounter newInstance = new RepeatCounter();
      Assert.Equal("1", newInstance.CountRepeats("This is a sentence", "is"));
    }
    [Fact]
    public void CountEachRepeatOfChosenWord_ReturnCounter()
    {
      RepeatCounter newInstance = new RepeatCounter();
      Assert.Equal("3", newInstance.CountRepeats("all in all is all we are", "all"));
    }
  }
}
