using Nancy;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        ScrabbleWord newWord = new ScrabbleWord(Request.Form["word"]);
        return View["index.cshtml", newWord];
      };
    }
  }
}
