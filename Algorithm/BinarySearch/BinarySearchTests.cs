using Xunit;

namespace Algorithm.BinarySearch;

public class BinarySearchTests
{
    [Fact]
    public void WhenSearching10Throw10SortedInts_ShouldReturnIndex0()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 10;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void WhenSearching20Throw10SortedInts_ShouldReturnIndex1()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 20;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void WhenSearching30Throw10SortedInts_ShouldReturnIndex2()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 30;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void WhenSearching50Throw10SortedInts_ShouldReturnIndex3()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 50;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void WhenSearching60Throw10SortedInts_ShouldReturnIndex4()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 60;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void WhenSearching80Throw10SortedInts_ShouldReturnIndex5()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 80;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void WhenSearching110Throw10SortedInts_ShouldReturnIndex6()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 110;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(6, result);
    }
    
    [Fact]
    public void WhenSearching130Throw10SortedInts_ShouldReturnIndex7()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 130;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(7, result);
    }
    
    [Fact]
    public void WhenSearching140Throw10SortedInts_ShouldReturnIndex8()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 140;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(8, result);
    }
    
    [Fact]
    public void WhenSearching170Throw10SortedInts_ShouldReturnIndex9()
    {
        var sortedArray = new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
        var target = 170;
        var sut = new BinarySearch(sortedArray, target);

        var result = sut.ProcessSearch();
        
        Assert.Equal(9, result);
    }
}