using Xunit;
using Access.FizzBuzz.Application.Rules;
using Access.FizzBuzz.Tests.Data;

namespace Access.FizzBuzz.Tests
{
    public class FizzRuleTest
    {
        private readonly FizzRule fizzRule;
        public FizzRuleTest()
        {
            fizzRule = new FizzRule();
        }

        [Theory]
        [ClassData(typeof(FizzRuleData))]
        public void Fizz_Rule_Tests((bool, string) expected, int input)
        {           
            var response = fizzRule.ExecuteRule(input);
            Assert.Equal(expected, response);
        }
    }
}
