using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CounterNameSpace
{

    public class WordCounter
  {

  public WordCounter()
  {
  }

  public static string GetSentence(string sentence)
  {
    return sentence;
  }
  public static string GetWord(string word)
  {
    return word;
  }
//   public void SetName(string sentence)
// {
//   _sentence = sentence;
// }

  public static int CountDraculaLoop(string sentence, string word) {

      string sentencelower = sentence.ToLower();
      string wordlower = word.ToLower();
      int count = (sentencelower.Length - sentencelower.Replace(wordlower, "").Length) / wordlower.Length;
      return count;

  }
}
}
