using Xunit;

namespace DataStructures.MStack;

public class MStackTests
{
    [Fact]
    public void WhenEmptyStackPushed_ShouldAddValue()
    {
        var sut = new MStack<string>();

        var result = sut.Push("Test");
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void WhenEmptyStackPopped_ShouldThrowException()
    {
        var sut = new MStack<string>();

        Assert.Throws<NullReferenceException>(() => sut.Pop());
    }
    
    [Fact]
    public void WhenFullStackPushed_ShouldThrowException()
    {
        var sut = new MStack<string>(1);
        
        sut.Push("Test");
        
        Assert.Throws<OverflowException>(() => sut.Push("Test"));
    }

    [Fact]
    public void WhenFullStackPopped_ShouldReturnValue()
    {
        var sut = new MStack<string>(1);
        sut.Push("Test");

        var result = sut.Pop();
        
        Assert.Equal("Test", result);
    }

    [Fact]
    public void When3ValuesPushedAnd2Popped_ShouldReturn2ndPushedValue()
    {
        var sut = new MStack<string>(3);
        sut.Push("First value");
        sut.Push("Second value");
        sut.Push("Third value");
        
        sut.Pop();
        var result = sut.Pop();
        
        Assert.Equal("Second value", result);
    }
    
    [Fact]
    public void WhenPoppedStackWithSingleValue_ShouldReturnIt()
    {
        var sut = new MStack<string>(1);
        sut.Push("Test");

        var result = sut.Pop();
        
        Assert.Equal("Test", result);
    }

    [Fact]
    public void WhenPoppedAllValues_ShouldClearStack()
    {
        var sut = new MStack<string>(2);
        sut.Push("Test");
        sut.Push("Test");

        sut.Pop();
        sut.Pop();
        
        Assert.Equal(0, sut.Count);
    }

    [Fact]
    public void WhenPushed2Values_ShouldContain2Values()
    {
        var sut = new MStack<string>(4);
        
        sut.Push("Test");
        sut.Push("Test");
        
        Assert.Equal(2, sut.Count);
    }

    [Fact]
    public void WhenStackInitializedWithNoArgs_ShouldHave1024Capacity()
    {
        var sut = new MStack<int>();

        for (int i = 0; i < 1024; i++)
        {
            sut.Push(i);
        }
        
        Assert.Equal(1024, sut.Count);
    }

    [Fact]
    public void WhenStackInitializedWithNoArgs_ShouldHaveNotMoreThen1024Capacity()
    {
        var sut = new MStack<int>();

        Assert.Throws<OverflowException>(() =>
        {
            for (int i = 0; i < 1025; i++)
            {
                sut.Push(i);
            }
        });
    }

    [Fact]
    public void WhenCapacitySet_ShouldDifferFromDefault()
    {
        var sut = new MStack<int>(1025);
        
        for (int i = 0; i < 1025; i++)
        {
            sut.Push(i);
        }
        
        Assert.Equal(1025, sut.Count);
    }
}