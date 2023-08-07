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
        
        Assert.True(xResult);
        Assert.True(yResult);
    }
}