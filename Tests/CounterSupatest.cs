using System.Collections.Generic;
using Xunit;
using WeekDaynamespace;


namespace  CounterNameSpace
{
  public class CounterTesting
  {
    [Fact]
    public void TestforSentence_CountDracula_sentence()
    {
      string sentence = "I have been expecting this test, Mr.Bond"

      Assert.Equal ("I have been expecting this test, Mr.Bond", WordCounter.CountDraculaLoop(sentence));
    }
    }
  }
