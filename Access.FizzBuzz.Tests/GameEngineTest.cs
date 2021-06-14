using Xunit;
using System.Collections.Generic;
using Access.FizzBuzz.Application;
using Access.FizzBuzz.Tests.Data;
using Access.FizzBuzz.Application.Rules;

namespace Access.FizzBuzz.Tests
{
    public class GameEngineTest
    {
        private readonly GameEngine gameEngine;
        public GameEngineTest()
        {
            var rules = new List<IRule>
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule(),
                new NotDividedByAnyGivenNumbersRule()
            };
            gameEngine = new GameEngine(rules);
        }
       
        [Theory]
        [ClassData(typeof(GameEngineData))]
        public void Play_Game_Tests_Return_Output(string expected, List<int> input)
        {
            string response = gameEngine.PlayGame(input);
            Assert.Equal(expected, response);
        }
    }
}
