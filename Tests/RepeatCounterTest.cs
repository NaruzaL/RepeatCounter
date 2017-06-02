using Xunit;
using System;
using System.Collections.Generic;
using RepeatCounterProject.Objects;

namespace RepeatCounterTest
{
  public class ReapeatCounterTest
  {
    [Fact]
    public void FindUserChosenWordInUseerSenetence_True()
    {
      RepeatCounter newInstance = new RepeatCounter();
      Assert.Equal("true", newInstance.CountRepeats("This is a sentence", "is"));
    }
  }
}
