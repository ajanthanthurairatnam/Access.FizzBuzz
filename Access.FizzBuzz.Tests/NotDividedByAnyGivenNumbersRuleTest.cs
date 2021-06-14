using Xunit;
using Access.FizzBuzz.Application.Rules;
using Access.FizzBuzz.Tests.Data;

namespace Access.FizzBuzz.Tests
{
    public class NotDividedByAnyGivenNumbersRuleTest
    {
        private readonly NotDividedByAnyGivenNumbersRule notDividedByAnyGivenNumbersRule;
        public NotDividedByAnyGivenNumbersRuleTest()
        {
            notDividedByAnyGivenNumbersRule = new NotDividedByAnyGivenNumbersRule();
        }

        [Theory]
        [ClassData(typeof(NotDividedByAnyGivenNumbersRuleData))]
        public void Not_Divided_By_Any_GivenNumbers_Rule_Tests((bool, string) expected, int input)
        {
            var response = notDividedByAnyGivenNumbersRule.ExecuteRule(input);
            Assert.Equal(expected, response);
        }
    }
}
