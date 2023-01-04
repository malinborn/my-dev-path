namespace learning_cs.MQueue;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> NextNode { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}