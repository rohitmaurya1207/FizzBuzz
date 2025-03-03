using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzProcessor.API.FizzBuzzProcessor.Core.Services;
using FluentAssertions;

namespace FizzBuzzProcessor.Tests.Services
{
    public class FizzBuzzServiceTests
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void ProcessFizzBuzz_ShouldReturnFizz_ForMultiplesOfThree()
        {
            var input = new List<string> { "3" };
            var result = _fizzBuzzService.ProcessFizzBuzz(input);
            result.Should().Contain("Fizz");
        }

        [Fact]
        public void ProcessFizzBuzz_ShouldReturnBuzz_ForMultiplesOfFive()
        {
            var input = new List<string> { "5" };
            var result = _fizzBuzzService.ProcessFizzBuzz(input);
            result.Should().Contain("Buzz");
        }

        [Fact]
        public void ProcessFizzBuzz_ShouldReturnFizzBuzz_ForMultiplesOfThreeAndFive()
        {
            var input = new List<string> { "15" };
            var result = _fizzBuzzService.ProcessFizzBuzz(input);
            result.Should().Contain("FizzBuzz");
        }

        [Fact]
        public void ProcessFizzBuzz_ShouldReturnInvalidItem_ForNonNumericValues()
        {
            var input = new List<string> { "A" };
            var result = _fizzBuzzService.ProcessFizzBuzz(input);
            result.Should().Contain("Invalid item");
        }
    }
}
