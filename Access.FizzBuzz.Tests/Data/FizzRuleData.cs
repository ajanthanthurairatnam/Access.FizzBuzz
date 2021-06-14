using System.Collections;
using System.Collections.Generic;

namespace Access.FizzBuzz.Tests.Data
{
    public class FizzRuleData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { (false, ""), 1 };
            yield return new object[] { (false, ""), 2 };
            yield return new object[] { (true, "fizz"), 3 };
            yield return new object[] { (false, ""), 4 };
            yield return new object[] { (false, ""), 5 };
            yield return new object[] { (true, "fizz"), 6 };
            yield return new object[] { (false, ""), 7 };
            yield return new object[] { (false, ""), 8 };
            yield return new object[] { (true, "fizz"), 9 };
            yield return new object[] { (false, ""), 10 };
            yield return new object[] { (false, ""), 11 };
            yield return new object[] { (true, "fizz"), 12 };
            yield return new object[] { (false, ""), 13 };
            yield return new object[] { (false, ""), 14 };
            yield return new object[] { (true, "fizz"), 15 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
