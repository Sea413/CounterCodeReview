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
    [Fact]
    public void TestforList_CountDraculaloop_List()
    {
      string sentence = "Never Give up on your dreams!";
      // string word = "Donnybrook";

      Assert.Equal ("Never Give up on your dreams!", WordCounter.CountDraculaLoop(sentence));
    }
    [Fact]
    public void TestforListfailure_CountDraculaloop_False()
    {
      string sentence = "-1";
      // string word = "Donnybrook";

      Assert.Equal ("-1", WordCounter.CountDraculaLoop(sentence));
    }
    [Fact]
    public void PreliminaryCountingTests_CountDraculaloop_Counting()
    {
      string sentence = "What a piece of work is a man! How noble in reason! how infinite in faculty! in form, in moving, how express and admirable! in action how like an angel! in apprehension how like a god! the beauty of the world! the paragon of animals! And yet, to me, what is this quintessence of dust?";
      string word = "like";
      // string word = "Donnybrook";

      Assert.Equal (2, WordCounter.CountDraculaLoop(sentence,word));
    }
    }
  }
