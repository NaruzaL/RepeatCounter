using Xunit;
using System;
using System.Collections.Generic;
using ReapeatCounterProject.Objects;

namespace RepeatCounterTest
{
  public class ReapeatCounter
  {
    [Fact]
    public void FindUserChosenWordInUseerSenetence_True()
    {
      ReapeatCounter newInstance = new ReapeatCounter();
      Assert.Equal(true, newInstance.CountRepeats("This is a sentence", "is"));
    }
  }
}
