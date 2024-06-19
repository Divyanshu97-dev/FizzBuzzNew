namespace FizzBuzzExcercise.Models
{
    public class FizzBuzzEntity
    {
        public enum DivisionResult
        {
            Fizz,
            Buzz,
            FizzBuzz,
            Value,
            InvalidItem
        }
    }
    public class DivisionData
    {
        public int Input { get; set; }
        public List<string> Results { get; set; } = new List<string>();
    }
}
