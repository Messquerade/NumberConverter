using System;
using System.Collections.Generic;


namespace NumberConverter.Models
{
  public class Convert
  {
    public static string NumberToText(int input)
    {
      Dictionary<int, string> toTextOneNine = new Dictionary<int, string>()
      {
        {1, "one"},
        {2, "two"},
        {3, "three"},
        {4, "four"},
        {5, "five"},
        {6, "six"},
        {7, "seven"},
        {8, "eight"},
        {9, "nine"}
      };
      Dictionary<int, string> toTextTens = new Dictionary<int, string>()
      {
        {10, "ten"},
        {11, "eleven"},
        {12, "twelve"},
        {13, "thirteen"},
        {14, "fourteen"},
        {15, "fifteen"},
        {16, "sixteen"},
        {17, "seventeen"},
        {18, "eighteen"},
        {19, "nineteen"}
      };

      return "zero";
    }

  }
}