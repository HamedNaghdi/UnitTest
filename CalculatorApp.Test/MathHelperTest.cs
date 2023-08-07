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
}