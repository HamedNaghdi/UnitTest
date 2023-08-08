namespace CalculatorApp.Test;

public class MathHelperTest
{
    [Fact]
    public void IsEvenTest()
    {
        var mathHelper = new MathHelper();

        int x = 1;
        int y = 2;
        
        var xResult = mathHelper.IsEven(x);
        var yResult = mathHelper.IsEven(y);
        
        Assert.False(xResult);
        Assert.True(yResult);
    }

    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(1, 3, 2)]
    public void DiffTest(int x, int y, int expectedValue)
    {
        var mathHelper = new MathHelper();
        var result = mathHelper.Diff(x, y);
        Assert.Equal(expected: expectedValue, result);
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 3, 2)]
    public void AddTest(int x, int y, int expectedValue)
    {
        var mathHelper = new MathHelper();
        var result = mathHelper.Add(x, y);
        Assert.Equal(expected: expectedValue, result);
    }
    
    [Theory]
    [InlineData(new[]{1,2,3}, 6)]
    [InlineData(new[]{2,4,6}, 12)]
    public void SumTest(int[] values, int expectedValue)
    {
        var mathHelper = new MathHelper();
        var result = mathHelper.Sum(values);
        Assert.Equal(expected: expectedValue, result);
    }
    
    [Theory]
    [InlineData(new[]{1,2,3}, 2)]
    [InlineData(new[]{-2,6,3}, 7/3)]
    public void AverageTest(int[] values, double expectedValue)
    {
        var mathHelper = new MathHelper();
        var result = mathHelper.Average(values);
        Assert.Equal(expected: expectedValue, result);
    }

    [Theory]
    [MemberData(nameof(MathHelper.Data), MemberType = typeof(MathHelper))]
    public void Add_MemberData_Test(int x, int y, int expectedValue)
    {
        var mathHelper = new MathHelper();
        var result = mathHelper.Add(x, y);
        Assert.Equal(expected: expectedValue, result);
    }

    [Theory]
    [ClassData(typeof(MathHelper))]
    public void Add_ClassData_Test(int x, int y, int expectedValue)
    {
        var mathHelper = new MathHelper();
        var result = mathHelper.Add(x, y);
        Assert.Equal(expected: expectedValue, result);
    }
}