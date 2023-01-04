using System.Net.Mail;
using System.Security.Cryptography;
using Xunit.Sdk;

namespace learning_cs.MQueue;

public class MQueue<T>
{
    public Node<T>? Head { get; private set; }
    public Node<T>? Rear { get; private set; }
    public int Count { get; set; }
    
    public MQueue<T> Enqueue(T value) // O(1)
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

        return this;
    }

    public T Dequeue()
    {
        if (Count == 0) throw new EmptyException("There are no values yet");

        var resulting = Head.Value;
        
        if (Count == 1)
        {
            Head = null;
        }
        else
        {
            Head = Head.NextNode;
        }

        Count--;
        return resulting;
    }
}