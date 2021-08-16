using System;
using FluentAssertions;
using Kata1_StringCalculator;
using Xunit;

namespace Kata1_StringCalculatorTests
{
    public class StringCalculatorTests
    {
        private StringCalculator _sut;

        public StringCalculatorTests()
        {
            _sut = new StringCalculator();
        }
        [Fact]
        public void Add_SupplyEmptyString_Returns0()
        {
            var result = _sut.Add("");
            result.Should().BeEquivalentTo("0", because: "adding nothing to nothing should give us nothing");
        }
        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("1.4", "1.4")]
        public void Add_SupplySingleNumber_ReturnsTheNumber(string input, string expectedResult)
        {
            var result = _sut.Add(input);
            result.Should().BeEquivalentTo(
                expectedResult, 
                because: "Supplying a single number should return the same number");
        }
        [Theory]
        [InlineData("1.1,2.2","3.3")]
        [InlineData("0,1", "1")]
        [InlineData("5.42,1", "6.42")]
        public void Add_SupplyTwoNumbers_ReturnsSumOfNumbers(string input, string expectedResult)
        {
            var result = _sut.Add(input);
            result.Should().BeEquivalentTo(
                expectedResult, 
                because: "Supplying two numbers should give you sum of the numbers");
        }
        [Theory]
        [InlineData("1,4,5.5,0,1.1", "11.6")]
        [InlineData("1,1,1,1,1","5")]
        [InlineData("0,0,0,0,0", "0")]
        public void Add_supplyingManyNumbers_ReturnsSumOfAllNumbers(string input, string expectedResult)
        {
            var result = _sut.Add(input);
            result.Should().BeEquivalentTo(
                expectedResult,
                because: "Supplying many numbers should give you sum of the numbers");
        }
        [Theory]
        [InlineData("1\n2,3", "6")]
        [InlineData("1\n1\n1\n1\n1", "5")]
        public void Add_supplyingNumbersDelimitedWithNewline_ReturnsSumOfAllNumbers(string input, string expectedResult)
        {
            var result = _sut.Add(input);
            result.Should().BeEquivalentTo(
                expectedResult,
                because: "Supplying many numbers should give you sum of the numbers");
        }

    }
}
