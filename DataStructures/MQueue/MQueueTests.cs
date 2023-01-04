using Xunit;

namespace learning_cs.MQueue;

public class MQueueTests
{
    [Fact]
    public void WhenEmptyQueueEnqueued_NewValueShouldBecomeHead()
    {
        var sut = new MQueue<string>();
        
        sut.Enqueue("Hello");
        
        Assert.Equal("Hello", sut.Head.Value);
    }

    [Fact]
    public void WhenQueueWithSingleValueEnqueued_ShouldMoveHeadToRear()
    {
        var sut = new MQueue<string>();
        sut.Enqueue("World");
        
        sut.Enqueue("Hello");
        
        Assert.Equal("World", sut.Rear.Value);
    }
    
    [Fact]
    public void WhenQueueWithSingleValueEnqueued_ShouldMakeNewHead()
    {
        var sut = new MQueue<string>();
        sut.Enqueue("World");
        
        sut.Enqueue("Hello");
        
        Assert.Equal("Hello", sut.Head.Value);
    }
}