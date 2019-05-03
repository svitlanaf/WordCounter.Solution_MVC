using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game/new")]
    public ActionResult New()
    {
     return View();
    }

    [HttpGet("/game")]
    public ActionResult Index()
    {
      List<Game> allGames = Game.GetAllGames();
      return View(allGames);
    }

    [HttpPost("/game")]
    public ActionResult Create(string wordInput, string sentenceInput)
    {
      Game.ClearAll();
      Game myGame = new Game(wordInput, sentenceInput);
      return RedirectToAction("Index");
    }
  }
}
