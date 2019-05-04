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
    [TestMethod]
    public void Index_HasCorrectModelType_ItemList()
    {
      ItemController controller = new ItemController();
      ViewResult indexView = controller.Index() as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(List<Item>));
    }


  }
}
