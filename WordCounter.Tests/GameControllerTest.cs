using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
  public class GameControllerTest
  {

    [TestMethod]
    public void NewGame_ReturnsCorrectView_True()
    {
        GameController controller = new GameController();
        ActionResult gameView = controller.NewGame();
        Assert.IsInstanceOfType(gameView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
        GameController controller = new GameController();
        RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;
        string result = actionResult.ActionName;
        Assert.AreEqual(result, "Index");
    }
  }
}

// [HttpPost("/game/result")]
//     public ActionResult Result(string wordInput, string sentenceInput)
//     {
//       Game myGame = new Game(wordInput, sentenceInput);
//       return View("Index", myGame);
//     }