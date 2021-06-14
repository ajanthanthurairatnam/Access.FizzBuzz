namespace Access.FizzBuzz.Application.Rules
{
    public class NotDividedByAnyGivenNumbersRule : IRule
    {
        public int Priority { get { return 4; } }
        public (int index, string description) Description { get; } = (4, "If the number is not divisible any of the above, should yield the number itself.");
        public (bool result, string output) ExecuteRule(int InputValue)
        {
            var isNotDividedByAnyNumbers = !(InputValue % 5 == 0 || InputValue % 3 == 0 || InputValue % 15 == 0);
            return isNotDividedByAnyNumbers ? (true, InputValue.ToString()) : (false, "");
        }
    }
}
