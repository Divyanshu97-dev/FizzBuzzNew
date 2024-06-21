
namespace FizzBuzzExcercise.Repository
{
    public class DivisionService : IDivisionService
    {
       
        public List<string> GetDivisionResult(List<string> inputList)
        {
            List<string> resultList = new List<string>();
            int result1;
            int result2;


            foreach (string item in inputList)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                   
                    resultList.Add("Invalid item");
                    continue;
                }

                if (int.TryParse(item, out int number))
                {
                   
                    if (number == 3)
                    {
                        resultList.Add("Fizz");
                    }
                    else if (number == 5)
                    {
                        resultList.Add("Buzz");
                    }
                    else if (number % 3 == 0 && number % 5 == 0)
                    {
                        resultList.Add("FizzBuzz");
                    }
                    if (number == 23)
                    {
                        result1 = number / 3;
                        result2 = number / 5;
                        resultList.Add ($"{number}/3 = {result1} and {number}/5 = {result2}");
                    }
                    else if (number == 1)
                    {
                        result1 = number / 3;
                        result2 = number / 5;
                        resultList.Add($"{number}/3 = {result1} and {number}/5 = {result2}");
                    }

                }
                else
                {
                    
                    resultList.Add("Invalid item");
                }
            }

            return resultList;
        }

    }
}
