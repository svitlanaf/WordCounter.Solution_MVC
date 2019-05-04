using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game/new")]
    public ActionResult NewGame()
    {
     return View("New");
    }

    [HttpPost("/game/result")]
    public ActionResult Result(string wordInput, string sentenceInput)
    {
      Game myGame = new Game(wordInput, sentenceInput);
      return View("Index", myGame);
    }

  }
}
