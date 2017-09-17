
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> newList = Console.ReadLine().Split().ToList();
        var stack = new StackOfStrings(newList);
        stack.Push("pesho");
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.IsEmpty());
        
    }
}
