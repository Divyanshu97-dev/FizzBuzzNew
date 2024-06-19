using static FizzBuzzExcercise.Models.FizzBuzzEntity;

namespace FizzBuzzExcercise.Repository
{
    public interface IDivisionService
    {
        DivisionResult GetDivisionResult(int input);
        List<string> GetDivisionLogs();
    }
}
