using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/object/new")]
    public ActionResult New()
    {
     return View();
    }

    [HttpPost("/object")]
    public ActionResult Create(string wordInput, string sentenceInput)
    {
      Game.ClearAll();
      Game myGame = new Game();
      return RedirectToAction("Index");
    }
  }
}
