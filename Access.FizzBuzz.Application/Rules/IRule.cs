namespace Access.FizzBuzz.Application.Rules
{
    public interface IRule
    {
        public int Priority { get; }
        public (int index,string description) Description { get;}
        public (bool result, string output) ExecuteRule(int InputValue);
    }
}
