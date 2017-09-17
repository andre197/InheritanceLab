
using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public StackOfStrings()
    {
        this.data = new List<string>();
    }

    public StackOfStrings(List<string> data)
    {
        this.data = data;
    }

    public void Push(string item)
    {
        this.data.Insert(0,item);
    }

    public string Pop()
    {
        var currStr = Peek();

        this.data.RemoveAt(0);

        return currStr;

    }

    public string Peek()
    {

        var currStr = this.data[0];
        return currStr;

    }

    public bool IsEmpty()
    {
        if (this.data.Count == 0)
        {
            return true;
        }
        return false;
    }
}

