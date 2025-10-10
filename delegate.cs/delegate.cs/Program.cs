using System;

delegate void greet();

class program
{

    static void sayhello()
    {
        Console.WriteLine("hello good afternoon students!");
    }


    static void Main()
    {
        greet g = sayhello;
        
        g();
    }
}