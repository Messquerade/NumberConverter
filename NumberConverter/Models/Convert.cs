using System;
using System.Collections.Generic;
using System.Linq;


namespace NumberConverter.Models
{
  public class Convert
  {
    public static string NumberToText(int input)
    {
      Dictionary<int, string> toTextOnes = new Dictionary<int, string>()
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
        {19, "nineteen"},
        {20, "twenty"},
        {30, "thirty"},
        {40, "forty"},
        {50, "fifty"},
        {60, "sixty"},
        {70, "seventy"},
        {80, "eighty"},
        {90, "ninety"}
      };

      // int[] numbersArray = Array.ConvertAll(input.ToString().ToArray(), x=>(int)x);
        int[] numbersArray = input.ToString().Select(c => (int)Char.GetNumericValue(c)).ToArray();
      
      string result = "";

      foreach (int number in numbersArray)
      {
        Console.WriteLine(number);
      }
      
      if (numbersArray.Length == 1)
      {
        result = toTextOnes[input];
      } else if (numbersArray[0] == 1 || numbersArray[1] == 0)
      {
        result = toTextTens[input];
      } else
      {
        result = toTextTens[numbersArray[0] * 10] +  " " + toTextOnes[numbersArray[1]];
      }
      return result;
    }

  }
}

