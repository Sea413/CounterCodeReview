using System.Collections.Generic;
using Xunit;
using CounterNameSpace;


namespace  CounterNameSpace
{
  public class CounterTesting
  {
    [Fact]
    public void TestforSentence_CountDraculaloop_sentence()
    {
      string sentence = "I have been expecting this test, Mr.Bond";

      Assert.Equal ("I have been expecting this test, Mr.Bond", WordCounter.CountDraculaLoop(sentence));
    }
    [Fact]
    public void TestforWord_CountDraculaloop_word()
    {
      string sentence = "Samuel L Jackson is fabulous!";
      string word = "Donnybrook";

      Assert.Equal ("Donnybrook", WordCounter.CountDraculaLoop(word));
    }
    }
  }
