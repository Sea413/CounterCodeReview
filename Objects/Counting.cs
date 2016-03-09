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

  public static int CountRepeats(string sentence, string word)
  {
  string sentencelower = sentence.ToLower();
  string wordlower = word.ToLower();
  string pattern = @"\b" + wordlower + @"\b";
  string replacement = "";
  string result = Regex.Replace(sentencelower, pattern, replacement);
  int count = (sentencelower.Length - result.Length) / wordlower.Length;
  return count;
  }
}
}
