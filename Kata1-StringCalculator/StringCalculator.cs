using System;

namespace Kata1_StringCalculator
{
    public class StringCalculator
    {
        public string Add(string stringOfNumbers)
        {
            if (string.IsNullOrWhiteSpace(stringOfNumbers))
            {
                return "0";
            }
            else
            {
                return stringOfNumbers;
            }
        }
    }
}
