using System.Collections;
using System.Collections.Generic;

namespace Access.FizzBuzz.Tests.Data
{
    public class BuzzRuleData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { (false, ""), 1 };
            yield return new object[] { (false, ""), 2 };
            yield return new object[] { (false, ""), 3 };
            yield return new object[] { (false, ""), 4 };
            yield return new object[] { (true, "buzz"), 5 };
            yield return new object[] { (false, ""), 6 };
            yield return new object[] { (false, ""), 7 };
            yield return new object[] { (false, ""), 8 };
            yield return new object[] { (false, ""), 9 };
            yield return new object[] { (true, "buzz"), 10 };
            yield return new object[] { (false, ""), 11 };
            yield return new object[] { (false, ""), 12 };
            yield return new object[] { (false, ""), 13 };
            yield return new object[] { (false, ""), 14 };
            yield return new object[] { (true, "buzz"), 15 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
