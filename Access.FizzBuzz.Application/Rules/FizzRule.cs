namespace Access.FizzBuzz.Application.Rules
{
    public class FizzRule : IRule
    {
        public int Priority { get { return 2; } }
        public (int index, string description) Description { get; } = (1, "If the number is divisible by 3, should yield the word 'fizz'");
        public (bool result, string output) ExecuteRule(int InputValue)
        {
            var isDividedByThree = InputValue % 3 == 0;
            return isDividedByThree ? (true, "fizz") : (false, "");
        }
    }
}
