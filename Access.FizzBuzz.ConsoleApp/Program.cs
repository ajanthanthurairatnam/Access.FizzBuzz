using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Access.FizzBuzz.Application;

namespace Access.FizzBuzz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddApplication();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var fizzBuzzGameConsole = serviceProvider.GetService<IGameEngine>();
            OutputToConsole(fizzBuzzGameConsole);
        }

        private static void OutputToConsole(IGameEngine fizzBuzzGameConsole)
        {
            Console.WriteLine("Fizz Buzz Game For Numbers From 1 to 100.");
            Console.WriteLine("Rules #");

            var gameRules = fizzBuzzGameConsole.GetGameRules();
            foreach (var (index, description) in gameRules)
            {
                Console.WriteLine($"{index}){description}");
            }

            Console.WriteLine("Lets play.....");
            List<int> numbers = Enumerable.Range(1, 100).ToList();
            Console.WriteLine(fizzBuzzGameConsole.PlayGame(numbers));
        }
    }
}
