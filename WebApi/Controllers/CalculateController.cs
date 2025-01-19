using BLL.Interfaces;
using BLL.models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : Controller
    {
        private readonly ICalculateBll _calculate;
        public CalculateController(ICalculateBll _Icalculate)
        {
            _calculate = _Icalculate;
        }

        [HttpPost("CalculateSalary")]
        public ActionResult<SalaryCalculationResult> CalculateSalary([FromBody] SalaryCalculationInput input)
        {
            if (input == null)
            {
                return BadRequest("Invalid input.");
            }

            var result = _calculate.CalculateSalary(input);
            return Ok(result);
        }
    }
}

