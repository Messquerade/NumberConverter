using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter.Models;

namespace NumberConverter.Models.Tests
{
  [TestClass]
  public class ConvertTests
  {
    [TestMethod]
    public void NumberToText_ConvertsOneThroughNine_Three()
    {
      Assert.AreEqual("three", Convert.NumberToText(3));
    }

    [TestMethod]
    public void NumberToText_ConvertsTensPlace_Eleven()
    {
      Assert.AreEqual("eleven", Convert.NumberToText(11));
    }

    [TestMethod]
    public void NumberToText_ConvertsTensPlaceWithOnesPlace_TwentyOne()
    {
      Assert.AreEqual("twenty one", Convert.NumberToText(21));
    }

    
  }
}