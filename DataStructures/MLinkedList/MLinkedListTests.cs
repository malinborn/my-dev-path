using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
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

    [Fact]
    public void WhenInsertValueInto0Index_ShouldBecomeHeadAndShiftHeadToIndex1()
    {
        var sut = new MLinkedList<string>("World!");
        
        sut.Insert(0, "Hello");
        
        Assert.Equal("Hello", sut.Get(0));
        Assert.Equal("World!", sut.Get(1));
    }
    
    [Fact]
    public void WhenInsertValueInto1Index_ShouldBecome1AndShiftIndex1ToIndex2()
    {
        var sut = new MLinkedList<string>("Zero");
        sut.Add("One");
        sut.Add("Two");

        sut.Insert(1, "Hello World!");
        
        Assert.Equal("Hello World!", sut.Get(1));
        Assert.Equal("One", sut.Get(2));
    }
    
    [Fact]
    public void WhenInsertValueInto4Index_ShouldBecome4AndShiftIndex1ToIndex5()
    {
        var sut = new MLinkedList<string>("Zero");
        sut.Add("One");
        sut.Add("Two");
        sut.Add("Three");
        sut.Add("Four");
        sut.Add("Five");

        sut.Insert(3, "Hello World!");
        
        Assert.Equal("Hello World!", sut.Get(3));
        Assert.Equal("Three", sut.Get(4));
    }

    [Fact]
    public void WhenInsertingOverListLength_ShouldThrowException()
    {
        var sut = new MLinkedList<string>();
        sut.Add("Hello!");

        Assert.Throws<IndexOutOfRangeException>(() =>
        {
            sut.Insert(9, "Test");
        });
    }
    
    [Fact]
    public void WhenInsertingIntoEmptyList_ShouldThrowException()
    {
        var sut = new MLinkedList<string>();
        sut.Add("Hello!");

        Assert.Throws<IndexOutOfRangeException>(() =>
        {
            sut.Insert(9, "Test");
        });
    }

    [Fact]
    public void WhenInsertingIntoLastIndex_ShouldShiftLastIntoNewLastAndBecomePreLast()
    {
        var sut = new MLinkedList<string>();
        sut.Add("Test1");
        sut.Add("Test2");
        sut.Add("Test3");
        
        sut.Insert(2, "Hello!");
        
        Assert.Equal("Hello!", sut.Get(2));
        Assert.Equal("Test3", sut.Get(3));
    }
}