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

    // [HttpGet("/game/new")]
    // public ActionResult NewGame()
    // {
    //  return View("New");
    // }

  }
}

