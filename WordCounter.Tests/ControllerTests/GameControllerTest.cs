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
    public void Result_HasCorrectModelType_True()
    {
      GameController controller = new GameController();
      ViewResult gameView = controller.Result("sun", "sun") as ViewResult;
      var a = gameView.ViewData.Model;
      Assert.IsInstanceOfType(a, typeof(Game));
    }


    [TestMethod]
    public void Result_ReturnsCorrectView_ReturnCount1()
    {
      GameController controller = new GameController();
      ViewResult gameView = controller.Result("sun", "sun") as ViewResult;
      Game myGame = gameView.ViewData.Model as Game;
      Assert.AreEqual(1, myGame.GetCount());
    }
  }
}
