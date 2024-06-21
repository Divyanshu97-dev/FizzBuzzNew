
using FizzBuzzExcercise.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


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

        [HttpPost]
        public ActionResult ProcessFizzBuzz(List<string> values)
        {
             var result = _divisionService.GetDivisionResult(values);
            
             return Ok(result);
        }

    }
}
