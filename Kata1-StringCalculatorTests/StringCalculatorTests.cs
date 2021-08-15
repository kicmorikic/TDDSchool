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
        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("1.4", "1.4")]
        public void Add_SupplySingleNumber_ReturnsTheNumber(string input, string expectedOutput)
        {
            var sut = new StringCalculator();
            var result = sut.Add(input);
            result.Should().BeEquivalentTo(expectedOutput, because: "Supplying a single number should return the same number");
        }
    }
}
