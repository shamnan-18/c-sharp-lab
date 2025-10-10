using System;

class Stack
{
    int[] stack = new int[10];
    int top = -1;
    public void Push(int value)
    {
        if (top == stack.Length - 1)
        {
            Console.WriteLine("Stack OverFlow");
        }
        else
        {
            stack[++top] = value;
            Console.WriteLine(value + " Pushed into stack ");

        }
    }
    public void Pop()
    {
        if(top == -1)
        {
            Console.WriteLine("Stack UnderFlow!");
        }
        else
        {
            Console.WriteLine("Stack Elements");
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine("Stack popped: "+stack[i]);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Stack s = new Stack();
        s.Push(10);
        s.Push(20);
        s.Push(30);
        s.Pop();

    }
}
