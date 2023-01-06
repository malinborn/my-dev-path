# Binary Search

Actually, I wrote quite a vast laboratory 
work to get better understanding of this 
algorithm.

Through it I noted some interesting relations
with binary system. 

For example, in worst cases of log2n 
(worst - giving the biggest subsets)
we can get answer the following rules:

--- 

Lets consider x - given number to search.

- We got number of bits following this formula: trunc(log2n) + 1, where n - length of given array;
- A comparison matches a bit from highest to lowest; 
- If x is bigger, than selected middle value of array, we write 1 to a bit and issue next comparison;
- If x is lower, than selected middle value of array, we write 0 to a bit and issue next comparison;
- If x is equal to selected middle value of array, we write 1 to a bit and fill remaining lower bits with 0's. 

Following this rules, you will get the binary number. Deduct 1 from it and you will get the index of x.

---

Those rules are working great with worst cases of n, but I couldn't describe mathematical correlation in other cases. Actually, I've seen it, but i could not describe it with math language, otherwise, I succeeded with algorithmical.

Unfortunately, I didn't commit procedural way and so my progress hasn't written, but I present the result. 

After my own implementation, I dug in .NET implementation and learned some important thing, like work of bit shifts (left shift corresponds multiplication by 2 and right shift to integer division by 2, yes, I know, it is kind of newby thing, but everybody has its white spots!)