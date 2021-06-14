using System.Collections;
using System.Collections.Generic;

namespace Access.FizzBuzz.Tests.Data
{
    public class FizzBuzzRuleData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { (false, ""), 11 };
            yield return new object[] { (false, ""), 12 };
            yield return new object[] { (false, ""), 13 };
            yield return new object[] { (false, ""), 14 };
            yield return new object[] { (true, "fizz buzz"), 15 };
            yield return new object[] { (true, "fizz buzz"), 30 };
            yield return new object[] { (false, ""), 31 };
            yield return new object[] { (false, ""), 32 };
            yield return new object[] { (false, ""), 33 };
            yield return new object[] { (false, ""), 34 };
            yield return new object[] { (false, ""), 41 };
            yield return new object[] { (false, ""), 42 };
            yield return new object[] { (false, ""), 43 };
            yield return new object[] { (false, ""), 44 };
            yield return new object[] { (true, "fizz buzz"), 45 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
