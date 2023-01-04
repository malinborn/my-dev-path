namespace learning_cs.MQueue;

public class MQueue<T>
{
    public Node<T> Head { get; set; }
    public Node<T> Rear { get; set; }
    public int Count { get; set; }

    public MQueue() { }

    public MQueue(T value)
    {
        Head = new Node<T>(value);
        Count++;
    }

    public void Enqueue(T value)
    {
        if (Count == 0)
        {
            Head = new Node<T>(value);
        }
        
    }

    public void Dequeue(T value)
    {
        
    }
}