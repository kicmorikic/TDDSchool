using System;
using System.Globalization;
using System.Linq;

namespace Kata1_StringCalculator
{
    public class StringCalculator
    {
        CultureInfo InvariantCulture = CultureInfo.InvariantCulture;
        public string Add(string stringOfNumbers)
        {
            if (string.IsNullOrWhiteSpace(stringOfNumbers))
            {
                return "0";
            }
            else
            {
                var splitNumbers = stringOfNumbers.Split(",");
                var sum = splitNumbers.Sum(numberString => decimal.Parse(numberString, InvariantCulture));

                return sum.ToString(InvariantCulture);
            }
        }
    }
}
