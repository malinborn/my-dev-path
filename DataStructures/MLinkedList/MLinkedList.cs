using Xunit.Sdk;

namespace DataStructures.MLinkedList;

public class MLinkedList<T>
{
    private Node<T>? _head = null;
    private Node<T> LastNode { get; set; }
    public int Count { get; private set; }

    public MLinkedList() {}

    public MLinkedList(T value)
    {
        _head = new Node<T>(value);
        LastNode = _head;
        Count++;
    }
    
    public int Add(T value)
    {
        if (_head is null)
        {
            _head = new Node<T>(value);
            LastNode = _head;
        }
        else
        {
            LastNode.NextNode = new Node<T>(value);
            LastNode = LastNode.NextNode;
        }
        Count++;
        return Count;
    }

    public Node<T> Find(T value)
    {
        if (_head is null)
        {
            throw new EmptyException("There are no nodes yet");
        }

        var  currentNode = _head;

        if (currentNode.Value.Equals(value))
        {
            return currentNode;
        }
        
        if (currentNode.NextNode is null && !currentNode.Value.Equals(value))
        {
            throw new DoesNotContainException(value, "There is no such value");
        }

        var resultingNode = ReverseSearch(currentNode, value);

        return resultingNode;
    }

    private Node<T> ReverseSearch(Node<T> currentNode, T value)
    {
        currentNode = currentNode.NextNode;
        if (currentNode.Value.Equals(value))
        {
            return currentNode;
        }
        if (currentNode.NextNode is not null && !currentNode.Value.Equals(value))
        {
            return ReverseSearch(currentNode, value);
        }
        throw new DoesNotContainException(value, "There is no such value");
    }

    public T Get(int index)
    {
        if (_head is null) throw new EmptyException("There are no nodes yet");
        
        if (index > Count - 1) throw new IndexOutOfRangeException();
        
        if (Count == 0) return _head.Value;

        Node<T> currentNode = _head;
        
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.NextNode;
        }

        return currentNode.Value;
    }
}