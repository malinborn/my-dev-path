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
        return GetNode(index).Value;
    }
    
    private Node<T> GetNode(int index)
    {
        if (_head is null) throw new EmptyException("There are no nodes yet");
        
        if (index < 0) index = NegativeToPositiveIndex(index);
        
        if (index >= Count) throw new IndexOutOfRangeException();
        
        if (Count == 0) return _head;

        Node<T> currentNode = _head;
        
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.NextNode;
        }

        return currentNode;
    }
    
    private Node<T> GetPreviousNode(int index)
    {
        if (index < 0) index = NegativeToPositiveIndex(index);
        Node<T> currentNode = _head;
        
        for (int i = 0; i < index - 1; i++)
        {
            currentNode = currentNode.NextNode;
        }

        return currentNode;
    }

    public void Insert(int index, T value)
    {
        if (index < 0) index = NegativeToPositiveIndex(index);
        if (index >= Count) throw new IndexOutOfRangeException();
        
        var newNode = new Node<T>(value);
        
        if (index == 0)
        {
            newNode.NextNode = _head;
            _head = newNode;
            Count++;
            return;
        }
        
        var previousNode = GetPreviousNode(index);
        var currentNode = previousNode.NextNode;
        previousNode.NextNode = newNode;
        newNode.NextNode = currentNode;
        Count++;
    }

    private int NegativeToPositiveIndex(int index)
    {
        return Count + index;
    }

    public T Delete(int index)
    {
        if (index < 0) index = NegativeToPositiveIndex(index);
        if (index == 0)
        {
            var headValue = _head.Value;
            _head = _head.NextNode;
            Count--;
            return headValue;
        }
        var previousNode = GetPreviousNode(index); 
        var currentNode = previousNode.NextNode; 
        var currentNodeValue = currentNode.Value; 
        previousNode.NextNode = currentNode.NextNode;
        Count--;
        return currentNodeValue;
    }
}