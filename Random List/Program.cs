
using System;

class Program
{
    static void Main(string[] args)
    {
        RandomList list = new RandomList()
        {
            "value1",
            "value2",
            "value3"

        };

        object rndStr = list.RandomString();

        Console.WriteLine(rndStr);
    }
}

