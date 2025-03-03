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

        [HttpPost("process")]
        public IActionResult Process([FromBody] List<string> values)
        {
            if (values == null || values.Count == 0)
                return BadRequest("Input cannot be empty.");

            var result = _fizzBuzzService.ProcessFizzBuzz(values);
            return Ok(result);
        }
    }
}
