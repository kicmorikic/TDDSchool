using System;
using System.Globalization;
using System.Linq;

namespace Kata1_StringCalculator
{
    public class StringCalculator
    {
        readonly CultureInfo _invariantCulture = CultureInfo.InvariantCulture;
        public string Add(string stringOfNumbers)
        {
            if (string.IsNullOrWhiteSpace(stringOfNumbers))
            {
                return "0";
            }
            else
            {
                var splitNumbers = stringOfNumbers.Split(",");
                var sum = splitNumbers.
                        Sum(numberString => 
                            decimal.Parse(numberString, _invariantCulture));

                return sum.ToString(_invariantCulture);
            }
        }
    }
}
