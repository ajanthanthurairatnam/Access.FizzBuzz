using Xunit;
using Access.FizzBuzz.Application.Rules;
using Access.FizzBuzz.Tests.Data;

namespace Access.FizzBuzz.Tests
{
    public class FizzBuzzRuleTest
    {
        private readonly FizzBuzzRule fizzBuzzRule;
        public FizzBuzzRuleTest()
        {
            fizzBuzzRule = new FizzBuzzRule();
        }

        [Theory]
        [ClassData(typeof(FizzBuzzRuleData))]
        public void Fizz_Buzz_Rule_Tests((bool, string) expected, int input)
        {           
            var response = fizzBuzzRule.ExecuteRule(input);
            Assert.Equal(expected, response);
        }
    }
}
