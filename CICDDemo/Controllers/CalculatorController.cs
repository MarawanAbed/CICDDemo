using CICDDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CICDDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            var calculator = new CalculatorService();

            var result = calculator.Add(a, b);

            return Ok(result);
        }
    }
}
