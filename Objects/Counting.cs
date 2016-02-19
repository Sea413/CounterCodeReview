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
    //
    // _sentence = sentence;
    // _word = word;
      int count = (sentence.Length - sentence.Replace(word, "").Length) / word.Length;
      return count;

  }
}
}
