using System;


class Program
{
    public static void Show()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("sham");
        queue.Enqueue("Charlie");
        queue.Enqueue("afra");
        queue.Enqueue("Bob");
        queue.Dequeue();

        foreach (string name in queue)
        {
            Console.WriteLine(name);
        }
    }
}

class MyClass
{
    static void Main()
    {
        Program.Show();
    }

}