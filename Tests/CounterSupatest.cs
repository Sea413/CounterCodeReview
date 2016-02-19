using System.Collections.Generic;
using Xunit;
using CounterNameSpace;


namespace  CounterNameSpace
{
  public class CounterTesting
  {
    [Fact]
    public void TestforSentence_CountRepeats_sentence()
    {
      string sentence = "I have been expecting this test, Mr.Bond";

      Assert.Equal ("I have been expecting this test, Mr.Bond", WordCounter.GetSentence(sentence));
    }
    [Fact]
    public void TestforWord_CountRepeats_word()
    {
      string word = "Donnybrook";

      Assert.Equal ("Donnybrook", WordCounter.GetWord(word));
    }
    // [Fact]
    // public void TestforList_CountRepeats_List()
    // {
    //   string sentence = "Never Give up on your dreams!";
    //   // string word = "Donnybrook";
    //
    //   Assert.Equal ("Never Give up on your dreams!", WordCounter.CountRepeats(sentence));
    // }
    // [Fact]
    // public void TestforListfailure_CountRepeats_False()
    // {
    //   string sentence = "-1";
    //   // string word = "Donnybrook";
    //
    //   Assert.Equal ("-1", WordCounter.CountRepeats(sentence));
    // }
    [Fact]
    public void PreliminaryCountingTests_CountRepeats_Counting()
    {
      string sentence = "What a piece of work is a man! How noble in reason! how infinite in faculty! in form, in moving, how express and admirable! in action how like an angel! in apprehension how like a god! the beauty of the world! the paragon of animals! And yet, to me, what is this quintessence of dust?";
      string word = "like";

      Assert.Equal (2, WordCounter.CountRepeats(sentence,word));
    }
    [Fact]
    public void Sensitivitytesting_CountRepeats_sentence()
    {
      string sentence = "Achilles glared at him and answered,Fool, prate not to me about covenants. There can be no covenants between men and lions, wolves and lambs can never be of one mind, but hate each other out and out an through. Therefore there can be no understanding between you and me, nor may there be any covenants between us, till one or other shall fall";

      string word = "CAN";

      Assert.Equal (3, WordCounter.CountRepeats(sentence,word));
    }
    }
  }
