using Xunit;

namespace learning_cs.MQueue;

public class MQueueTests
{
    [Fact]
    public void WhenEmptyQueueEnqueued_NewValueShouldBecomeRear()
    {
        var sut = new MQueue<string>();
        
        sut.Enqueue("Hello");
        
        Assert.Equal("Hello", sut.Rear.Value);
    }
    
    [Fact]
    public void WhenEmptyQueueEnqueued_NewValueShouldBecomeHead()
    {
        var sut = new MQueue<string>();
        
        sut.Enqueue("Hello");
        
        Assert.Equal("Hello", sut.Head.Value);
    }

    [Fact]
    public void WhenQueueWithSingleValueEnqueued_ShouldMoveRearToHead()
    {
        var sut = new MQueue<string>();
        sut.Enqueue("World");
        
        sut.Enqueue("Hello");
        
        Assert.Equal("Hello", sut.Rear.Value);
    }
    
    [Fact]
    public void WhenQueueWithSingleValueEnqueued_ShouldMakeNewRear()
    {
        var sut = new MQueue<string>();
        sut.Enqueue("Hello");
        
        sut.Enqueue("World");
        
        Assert.Equal("World", sut.Rear.Value);
    }

    [Fact]
    public void WhenQueueWithMoreThan2ValueEnqueued_ShouldMoveRear()
    {
        var sut = new MQueue<string>();
        sut.Enqueue("Test1");
        sut.Enqueue("Test2");
        
        sut.Enqueue("Test3");
        
        Assert.Equal("Test3", sut.Rear.Value);
    }
}