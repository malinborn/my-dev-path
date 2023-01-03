namespace DataStructures.MStack;

public class MStack <T>
{
    private const int DefaultCapacity = 1024;
    private T[] _bucket;
    private int _freeCellIndex;
    public int Count
    {
        get { return _freeCellIndex; }
    }

    public MStack()
    {
        _bucket = new T[DefaultCapacity];
        _freeCellIndex = 0;
    }

    public MStack(int userCapacity)
    {
        _bucket = new T[userCapacity];
        _freeCellIndex = 0;
    }

    public int Push(T value)
    {
        if (_freeCellIndex == _bucket.Length)
        {
            throw new OverflowException("Stack overflowed with values");
        }

        _bucket[_freeCellIndex] = value;
        _freeCellIndex++;
        return _freeCellIndex - 1;
    }

    public T Pop()
    {
        if (_freeCellIndex == 0)
        {
            throw new NullReferenceException("There is no values yet in this stack");
        }

        _freeCellIndex--;
        return _bucket[_freeCellIndex];
    }
}