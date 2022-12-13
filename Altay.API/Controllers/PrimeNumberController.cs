using Altay.Core.Maths;
using Microsoft.AspNetCore.Mvc;

namespace Altay.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeNumberController : ControllerBase
    {

        private readonly ILogger<PrimeNumberController> _logger;

        public PrimeNumberController(ILogger<PrimeNumberController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/GetClosestPrimeNumber")]
        public ActionResult GetClosestPrimeNumber(int[] numbers)
        {
            PrimeNumber primeNumber = new();
            return Ok(new { statusCode = "200", data = primeNumber.GetClosestPrimeNumber(numbers)});
        }
    }
}