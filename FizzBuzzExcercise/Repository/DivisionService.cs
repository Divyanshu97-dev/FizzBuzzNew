using FizzBuzzExcercise.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static FizzBuzzExcercise.Models.FizzBuzzEntity;
using static System.Reflection.Metadata.BlobBuilder;

namespace FizzBuzzExcercise.Repository
{
    public class DivisionService : IDivisionService
    {
        private List<string> _logs = new List<string>();

        public int value1;
        public int value2;
        
        public FizzBuzzEntity.DivisionResult GetDivisionResult(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                
                _logs.Add($"FizzBuzz");
                return DivisionResult.FizzBuzz;
                
            }
            else if (input % 3 == 0)
            {
               _logs.Add($"Fizz");
                return DivisionResult.Fizz;
            }
            else if (input % 5 == 0)
            {
                _logs.Add($"Buzz");
                return DivisionResult.Buzz;
            }
            else if (input == 1)
            {
                value1= input / 3;
                value2= input / 5;
                _logs.Add($"Divided {input} by 3:-{value1}");
                _logs.Add($"Divided {input} by 5:-{value2}");
                return DivisionResult.Value;

            }
            else if (input == 23)
            {
                 value1 = input / 3;
                 value2 = input / 5;
                _logs.Add($"Divided {input} by 3:-{value1}");
                _logs.Add($"Divided {input} by 5:-{value2}");
                return DivisionResult.Value;

            }
            else
            {
                _logs.Add($"Invalid Item");
                return DivisionResult.InvalidItem;
            }
        }
        public List<string> GetDivisionLogs()
        {
            return _logs;
        }
    }
}
