
using System;
using System.Collections;
public class RandomList : ArrayList
{
    public object RandomString()
    {
        Random rnd = new Random();
        int n = rnd.Next(0, base.Count);

        var o = base[n];

        base.RemoveAt(n);

        return o;
    }
}

