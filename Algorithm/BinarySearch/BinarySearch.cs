using Xunit.Sdk;

namespace Algorithm.BinarySearch;

public class BinarySearch
{
    private int[] _sortedArray;
    private int _target;
    private int _maxCompareTimes;
    public BinarySearch(int[] sortedArray, int target)
    {
        _sortedArray = sortedArray;
        _target = target;
        _maxCompareTimes = Convert.ToInt32(Math.Truncate(Math.Log2(_sortedArray.Length)));
    }

    public int ProcessSearch()
    {
        int first = 0;
        int last = _sortedArray.Length - 1;
        int middle;
        while (first <= last)
        {
            middle = first + ((last - first) >> 2);
            if (_sortedArray[middle] == _target) return middle;
            else if (_sortedArray[middle] < _target) first = middle + 1;
            else if (_sortedArray[middle] > _target) last = middle - 1;
        }
        return -1;
    }
}