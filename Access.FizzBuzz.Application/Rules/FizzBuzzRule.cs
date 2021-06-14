namespace Access.FizzBuzz.Application.Rules
{
    public class FizzBuzzRule : IRule
    {
        public int Priority { get { return 1; } } 
        public (int index, string description) Description { get; } = (3, "If the number is divisible by 15, should yield the word 'fizz buzz'");
        public (bool result, string output) ExecuteRule(int InputValue)
        {
            var isDividedByFive = InputValue % 15 == 0;
            return isDividedByFive ? (true, "fizz buzz") : (false, "");
        }
    }
}
