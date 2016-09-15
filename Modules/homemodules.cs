using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Nancy;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/result"] = _ =>
      {
        ScrabbleWord newScrabbleWord = new ScrabbleWord(Request.Form["scrabbleWordForm"]);
        newScrabbleWord.SetUserScore();
        return View["result.cshtml" , newScrabbleWord ];
      };

    }
  }
}
