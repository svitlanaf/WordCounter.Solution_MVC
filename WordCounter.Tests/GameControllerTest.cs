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
    public void Result_ReturnsCorrectView_ReturnCount1_Index()
    {
        GameController controller = new GameController();
        ActionResult gameView = controller.Result("sun", "sun");
        Assert.AreEqual("Index", @Model.GetCount());
    }
  }
}
