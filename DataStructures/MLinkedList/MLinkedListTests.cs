using Xunit;
using Xunit.Sdk;

namespace DataStructures.MLinkedList;

public class MLinkedListTests
{
    [Fact]
    public void WhenInitializedWithNoValues_CountShouldBe0()
    {
        var sut = new MLinkedList<string>();
        
        Assert.Equal(0, sut.Count);
    }

    [Fact]
    public void WhenInitializedWithValue_CountShouldBe1()
    {
        var sut = new MLinkedList<string>("Hello World!");
        
        Assert.Equal(1, sut.Count);
    }
    
    [Fact]
    public void WhenValuesAdded_CountShouldIncrement()
    {
        var sut = new MLinkedList<string>();
        
        sut.Add("Hello");
        sut.Add("World");
        
        Assert.Equal(2, sut.Count);
    }
    
    [Fact]
    public void WhenSearchWithIndexFromListWithSingleValue_ShouldReturnThatValue()
    {
        var sut = new MLinkedList<string>();
        sut.Add("Hello");

        var result = sut.Get(0);
        
        Assert.Equal("Hello", result);
    }
    
    [Fact]
    public void WhenSearchWithIndex_ShouldReturnValue()
    {
        var sut = new MLinkedList<string>();
        sut.Add("Hello");
        sut.Add("World");

        var result = sut.Get(1);
        
        Assert.Equal("World", result);
    }

    [Fact]
    public void WhenSearchingWithValue_ShouldReturnContainingNode()
    {
        var sut = new MLinkedList<string>();
        sut.Add("Hello");
        sut.Add("World");
        sut.Add("!!!");
        var properNode = new Node<string>("!!!");  

        var result = sut.Find("!!!");
        
        Assert.Equivalent(properNode, result);
    }

    [Fact]
    public void WhenInitializedWithNoValuesAndSearch_ShouldThrowEmptyException()
    {
        var sut = new MLinkedList<string>();
        
        Assert.Throws<EmptyException>(() =>
        {
            sut.Find("Hello!");
        });
    }
    
    [Fact]
    public void WhenSearchThrowListWithNoNeededValue_ShouldThrowDoesNotContainException()
    {
        var sut = new MLinkedList<string>("Hello!");
        sut.Add("World!");
        
        Assert.Throws<DoesNotContainException>(() =>
        {
            sut.Find("!!!");
        });
    }
    
    [Fact]
    public void WhenSearchThrowListWithNoNeededIndex_ShouldThrowIndexOutOfRangeException()
    {
        var sut = new MLinkedList<string>("Hello!");
        sut.Add("World!");
        
        Assert.Throws<IndexOutOfRangeException>(() =>
        {
            sut.Get(9);
        });
    }
}