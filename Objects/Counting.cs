using System;
using System.Collections.Generic;
using System.Linq;

namespace CounterNameSpace
{

    public class WordCounter
  {

  public WordCounter()
  {
  }

public static string CountDraculaLoop(string sentence)
{

  // string sentence1 = sentence;
  // string word1 = word;

  List<string> result = sentence.Split(',').ToList();
  string newresult = string.Join(",", result.ToArray());
  return newresult;
}
}
}
