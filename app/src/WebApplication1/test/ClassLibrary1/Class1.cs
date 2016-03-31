using Xunit;
using WebApplication1.Controllers;

public class Class1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        var myObj = new ValuesController();
        Assert.Equal("Stringy", myObj.thingy);

        Assert.Equal(7, Add(4, 3));
    }

    int Add(int x, int y)
    {
        return x + y;
    }
}
