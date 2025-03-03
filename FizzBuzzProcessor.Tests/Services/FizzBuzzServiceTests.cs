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
            var input = 3;
            var result = _fizzBuzzService.GetFizzBuzzResult(input);
            result.Should().Contain("Fizz");
        }

        [Fact]
        public void ProcessFizzBuzz_ShouldReturnBuzz_ForMultiplesOfFive()
        {
            var input = 5;
            var result = _fizzBuzzService.GetFizzBuzzResult(input);
            result.Should().Contain("Buzz");
        }

        [Fact]
        public void ProcessFizzBuzz_ShouldReturnFizzBuzz_ForMultiplesOfThreeAndFive()
        {
            var input = 15;
            var result = _fizzBuzzService.GetFizzBuzzResult(input);
            result.Should().Contain("FizzBuzz");
        }
    }
}
