namespace FizzBuzzProcessor.API.FizzBuzzProcessor.Core.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> ProcessFizzBuzz(List<string> inputs)
        {
            var results = new List<string>();

            foreach (var input in inputs)
            {
                if (!int.TryParse(input, out int number))
                {
                    results.Add("Invalid item");
                    continue;
                }

                if (number % 3 == 0 && number % 5 == 0)
                    results.Add("FizzBuzz");
                else if (number % 3 == 0)
                    results.Add("Fizz");
                else if (number % 5 == 0)
                    results.Add("Buzz");
                else
                {
                    results.Add($"Divided {number} by 3");
                    results.Add($"Divided {number} by 5");
                }
            }

            return results;
        }
    }
}
