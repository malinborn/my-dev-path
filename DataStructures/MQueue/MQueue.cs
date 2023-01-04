namespace learning_cs.MQueue;

public class MQueue<T>
{
    public Node<T> Head { get; set; }
    public Node<T> Rear { get; set; }
    public int Count { get; set; }
    
    public void Enqueue(T value) // O(1)
    {
        if (Count == 0)
        {
            var newNode = new Node<T>(value);
            Rear = newNode;
            Head = newNode;
            
        }
        else
        {
            var newNode = new Node<T>(value);
            Rear.NextNode = newNode;
            Rear = newNode;
        }
        Count++;
    }

    public void Dequeue(T value)
    {
        
    }
}