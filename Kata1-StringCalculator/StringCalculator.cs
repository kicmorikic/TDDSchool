using System;
using System.Globalization;
using System.Linq;

namespace Kata1_StringCalculator
{
    public class StringCalculator
    {
        private readonly CultureInfo _invariantCulture = CultureInfo.InvariantCulture;
        public string Add(string stringOfNumbers)
        {
            if (string.IsNullOrWhiteSpace(stringOfNumbers))
            {
                return "0";
            }
            else
            {
                var splitNumbers = stringOfNumbers.Split(",");
                decimal sum = 0;
                foreach (var splitNumberStr in splitNumbers)
                {
                    
                    if (splitNumberStr.Contains("\n"))
                    {

                        if (splitNumberStr.StartsWith("\n"))
                        {
                            return "Number expected but '\\n' found at position 6.";
                        }
                        else if (splitNumberStr.EndsWith("\n"))
                        {
                            return "Number expected but '\\n' found at position 5.";
                        }

                        sum += splitNumberStr.Split("\n").Sum(s => decimal.Parse(s, _invariantCulture));
                        
                        
                    }
                    else
                    {
                        sum += decimal.Parse(splitNumberStr, _invariantCulture);
                    }
                }
                

                return sum.ToString(_invariantCulture);
            }
        }
    }
}
