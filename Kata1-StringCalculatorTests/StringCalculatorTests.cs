using System;
using FluentAssertions;
using Kata1_StringCalculator;
using Xunit;

namespace Kata1_StringCalculatorTests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_SupplyEmptyString_Returns0()
        {
            var sut = new StringCalculator();
            var result = sut.Add("");
            result.Should().BeEquivalentTo("0", because: "adding nothing to nothing should give us nothing");

        }
    }
}
