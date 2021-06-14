namespace Access.FizzBuzz.Application.Rules
{
    public class BuzzRule : IRule
    {      
        public int Priority { get { return 2; } }
        public (int index, string description) Description { get; } = (2, $"If the number is divisible by 5, should yield the word 'buzz'");
        public (bool result, string output) ExecuteRule(int InputValue)
        {
            var isDividedByFive = InputValue % 5 == 0;
            return isDividedByFive ? (true, "buzz") : (false, "");
        }
    }
}
