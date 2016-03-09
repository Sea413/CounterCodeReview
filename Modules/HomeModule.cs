using Nancy;
using System.Collections.Generic;
using CounterNameSpace;

namespace CounterNameSpace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
    Get["/"] = _ => {
     return View["index.cshtml"];
    };
    Post ["/results"]= _ => {
     var newWordCounter = WordCounter.CountRepeats(Request.Form["sentence-id"], Request.Form["word-id"]);
     return View ["results.cshtml", newWordCounter];
    };
    }
  }
}
