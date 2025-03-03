using FizzBuzzProcessor.API.FizzBuzzProcessor.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzProcessor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpGet("{number}")]
        public IActionResult GetFizzBuzz(int number)
        {
            var result = _fizzBuzzService.GetFizzBuzzResult(number);
            return Ok(result);
        }
    }
}
