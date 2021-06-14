using System.Collections.Generic;

namespace Access.FizzBuzz.Application
{
    public interface IGameEngine
    {
        public IEnumerable<(int index, string description)> GetGameRules();
        public IEnumerable<string> ExecuteGameRules(List<int> numbers);
        public string PlayGame(List<int> numbers);
    }
}
