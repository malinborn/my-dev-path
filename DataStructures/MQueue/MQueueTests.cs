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
}