namespace FizzBuzzProcessor.API.FizzBuzzProcessor.Core.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private const int FizzNumber = 3;
        private const int BuzzNumber = 5;

        public string GetFizzBuzzResult(int number)
        {
            if (number % FizzNumber == 0 && number % BuzzNumber == 0) return "FizzBuzz";
            if (number % FizzNumber == 0) return "Fizz";
            if (number % BuzzNumber == 0) return "Buzz";
            return number.ToString();
        }
    }
}
