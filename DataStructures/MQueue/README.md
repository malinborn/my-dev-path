# Queue
___
So I discovered queue data structure (DS) for myself and implemented it via .NET C#.

I learned, that it is algorithmically cheap DS, all of the operations are O(1).

Also I found option of queue implementation via two stacks. This approach has it's own pros and cons, like: 

[+] Stack are usually implemented via arrays, so this option allows us to store data contiguously. It cheapens memory operations.

[–] Algorithmic difficulty of one of Enqueue or Dequeue is getting 0(1) -> 0(n). Which is raising the price of CPU operations.

[–] Possibility of stack overflow exception, or another O(n) operation with reassemble of both stacks. 
___ 

For a queue, I would prefer linked list implementation. 

It solves problem of possible stack overflow and provides me 0(1) difficulty for all operations.