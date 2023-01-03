namespace DataStructures.MLinkedList;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? NextNode { get; set; } = null;

    public Node(T value)
    {
        Value = value;
    }
}