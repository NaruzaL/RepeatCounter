using Nancy;
using System.Collections.Generic;
using RepeatCounterProject.Objects;

namespace RepeatCounterProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ => View["index.cshtml"];

      Post["/result"]= _ => {
        RepeatCounter newRepeatCounter = new RepeatCounter();
        string result = newRepeatCounter.CountRepeats(Request.Form["userSentence"], Request.Form["wordToFind"]);
        return View["result.cshtml", result];
      };
    }
  }
}
