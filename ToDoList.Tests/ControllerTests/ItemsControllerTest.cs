using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemsControllerTest
  {
  }

  [TestMethod]
  public void Index_ReturnsCorrectView_True()
  {
    //Arrange
    ItemsController controller = new ItemsController();

    //Act
    ActionResult indexView = controller.Index();

    //Assert
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
  }

  [TestMethod]
  public void Index_HasCorrectModelType_ItemList()
  {
    //Arrange
    ItemsController controller = new ItemsController();
    IActionResult actionResult = controller.Index();
    ViewResult indexView = controller.Index() as ViewResult;

    //Act
    var result = indexView.ViewData.Model;

    //Assert
    Assert.IsInstanceOfType(result, typeof(List<Item>));
  }

}