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
  }
}

// C:\Users\Anna\Desktop\NumberConverter.Solution\NumberConverter.Tests\ModelTests\ConvertTests.cs(12,32): error CS0234: The type or namespace name 'NumberToText' does not exist in the namespace 'NumberConverter' (are you missing an assembly reference?) [C:\Users\Anna\Desktop\NumberConverter.Solution\NumberConverter.Tests\NumberConverter.Tests.csproj]