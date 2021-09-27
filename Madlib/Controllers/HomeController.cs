using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
    public class HomeController : Controller
  {
    // [Route("/")]
    // public ActionResult Letter()
    // {
    //   LetterVariable myLetterVariable = new LetterVariable();
    //   myLetterVariable.Recipient = "Lina";
    //   myLetterVariable.Sender = "Jasmine";
    //   return View(myLetterVariable);
    // }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/Madlib")]
    public ActionResult Madlib(string propernoun, string verb, string adjective, string place, string number, string year)
    {
      MadlibVariable myMadLibVariable = new MadlibVariable();
      myMadLibVariable.ProperNoun = propernoun;
      myMadLibVariable.Verb = verb;
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.Place = place;
      myMadLibVariable.Number = number;
      myMadLibVariable.Year = year;
      return View(myMadLibVariable);
    }
  }
}