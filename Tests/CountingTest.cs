using System.Collections.Generic;
using Xunit;
using CounterNameSpace;


namespace CounterNameSpace
{
  public class CounterTesting
  {
    [Fact]
    public void Determine_CountRepeats_Onewordrepeat()
    {
      string sentence = "like";
      string word = "like";

      Assert.Equal (1, WordCounter.CountRepeats(sentence,word));
    }
    [Fact]
    public void Determine_CountRepeats_Wordsaredistinct()
    {
      string sentence = "Not";
      string word = "like";

      Assert.Equal (0, WordCounter.CountRepeats(sentence,word));
    }
    [Fact]
    public void Determine_CountRepeats_CaseSensitive()
    {
      string sentence = "Like";
      string word = "like";

      Assert.Equal (1, WordCounter.CountRepeats(sentence,word));
    }
    [Fact]
    public void Determine_CountRepeats_DoesNotCountPartialMatch()
    {
      string sentence = "Like and Likeness";
      string word = "Like";

      Assert.Equal (1, WordCounter.CountRepeats(sentence,word));
    }
    [Fact]
    public void Determine_CountRepeats_RecognizedMoreThanOnce()
    {
      string sentence = "Like and Likeness other like";
      string word = "Like";

      Assert.Equal (2, WordCounter.CountRepeats(sentence,word));
    }
  }
}
