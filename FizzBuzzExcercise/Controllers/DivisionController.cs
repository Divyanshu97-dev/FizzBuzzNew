using FizzBuzzExcercise.Models;
using FizzBuzzExcercise.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static FizzBuzzExcercise.Models.FizzBuzzEntity;

namespace FizzBuzzExcercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly IDivisionService _divisionService;

        public DivisionController(IDivisionService divisionService)
        {
            _divisionService = divisionService;
        }

        [HttpPost("ProcessArray")]
        public ActionResult<List<DivisionData>> ProcessArray(int[] values)
        {
            if (values == null || values.Length == 0)
                return BadRequest("Invalid Item");

            var results = new List<DivisionData>();
            foreach (var value in values)
            {
                var divisionResult = _divisionService.GetDivisionResult(value);
                var logs = _divisionService.GetDivisionLogs();

                var divisionInfo = new DivisionData
                {
                    Input = value,
                    Results = logs
                };

                results.Add(divisionInfo);
            }

            return Ok(results);
        }

    }
}
