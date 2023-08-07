using System.Collections;

namespace CalculatorApp;

public class MathHelper : IEnumerable<object[]>
{
    public bool IsEven(int number) => number % 2 == 0;

    public int Diff(int x, int y) => y - x;

    public int Add(int x, int y) => x + y;

    public int Sum(params int[] values)
    {
        var sum = 0;
        foreach (var value in values)
            sum += value;
        return sum;
    }

    public double Average(params int[] values)
    {
        var sum = 0;
        foreach (var value in values)
            sum += value;
        return sum/values.Length;
    }

    public IEnumerable<object[]> Data => new List<object[]>
    {
        new object[] { 1, 2, 3 },
        new object[] { -4, -6, -10 },
        new object[] { -2, 2, 0 },
        new object[]{-int.MaxValue, 0, int.MaxValue}
    };
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { -4, -6, -10 };
        yield return new object[] { -2, 2, 0 };
        yield return new object[] { -int.MaxValue, 0, int.MaxValue };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}