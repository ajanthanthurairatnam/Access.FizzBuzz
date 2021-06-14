using System.Collections;
using System.Collections.Generic;

namespace Access.FizzBuzz.Tests.Data
{
    public class GameEngineData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "1 2 fizz 4 buzz fizz 7 8 fizz buzz", new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
            yield return new object[] { "fizz buzz 31 32 fizz 34 buzz fizz 37", new List<int>() { 30, 31, 32, 33, 34, 35, 36, 37 } };
            yield return new object[] { "buzz fizz buzz 61 fizz fizz buzz 76", new List<int>() { 55, 60, 61, 63, 75, 76 } };
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
