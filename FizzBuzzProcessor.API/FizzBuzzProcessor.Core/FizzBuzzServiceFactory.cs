using FizzBuzzProcessor.API.FizzBuzzProcessor.Core.Services;

namespace FizzBuzzProcessor.API.FizzBuzzProcessor.Core
{
    public class FizzBuzzServiceFactory
    {
        public static IFizzBuzzService CreateService()
        {
            return new FizzBuzzService();
        }
    }
}
