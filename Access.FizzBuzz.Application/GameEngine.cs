using System.Collections.Generic;
using System.Linq;
using Access.FizzBuzz.Application.Rules;

namespace Access.FizzBuzz.Application
{
    public class GameEngine : IGameEngine
    {
        public GameEngine(IEnumerable<IRule> Rules)
        {
            this.Rules = Rules;
        }

        private IEnumerable<IRule> Rules { get; set; }

        public string PlayGame(List<int> numbers)
        {
            return string.Join(" ", ExecuteGameRules(numbers).ToArray());
        }

        public IEnumerable<(int index,string description)> GetGameRules()
        {
            return Rules.OrderBy(o => o.Description.index).Select(e => e.Description);
        }

        public IEnumerable<string> ExecuteGameRules(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                foreach (var rule in Rules.OrderBy(e => e.Priority))
                {
                    if (rule.ExecuteRule(number).result)
                    {
                        yield return rule.ExecuteRule(number).output;
                        break;
                    }
                }
            }
        }
    }
}
