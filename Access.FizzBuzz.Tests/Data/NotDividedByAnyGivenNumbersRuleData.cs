using System.Collections;
using System.Collections.Generic;

namespace Access.FizzBuzz.Tests.Data
{
    public class NotDividedByAnyGivenNumbersRuleData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { (true, "1"), 1 };
            yield return new object[] { (true, "2"), 2 };
            yield return new object[] { (false, ""), 3 };
            yield return new object[] { (true, "4"), 4 };
            yield return new object[] { (false, ""), 5 };
            yield return new object[] { (false, ""), 6 };
            yield return new object[] { (true, "7"), 7 };
            yield return new object[] { (true, "8"), 8 };
            yield return new object[] { (false, ""), 9 };
            yield return new object[] { (false, ""), 10 };
            yield return new object[] { (true, "11"), 11 };
            yield return new object[] { (false, ""), 12 };
            yield return new object[] { (true, "13"), 13 };
            yield return new object[] { (true, "14"), 14 };
            yield return new object[] { (false, ""), 15 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
