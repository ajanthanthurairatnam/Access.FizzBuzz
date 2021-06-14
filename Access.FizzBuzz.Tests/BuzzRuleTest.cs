using Xunit;
using Access.FizzBuzz.Application.Rules;
using Access.FizzBuzz.Tests.Data;

namespace Access.FizzBuzz.Tests
{
    public class BuzzRuleTest
    {
        private readonly BuzzRule buzzRule;
        public BuzzRuleTest()
        {
            buzzRule = new BuzzRule();
        }
        [Theory]
        [ClassData(typeof(BuzzRuleData))]
        public void Buzz_Rule_Tests((bool, string) expected, int input)
        {
            var response = buzzRule.ExecuteRule(input);
            Assert.Equal(expected, response);
        }
    }
}
