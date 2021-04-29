using System;
using System.Collections;
using System.Collections.Generic;
class sk
{
    public static void Main()
    {
        LinkedList<string> ll = new LinkedList<string>();
        ll.AddLast("santosh");
        ll.AddLast("kumar");
        ll.AddLast("is");
        ll.AddLast("in");
        ll.AddLast("INDIA");
        Console.WriteLine(ll.First.Value);
        Console.WriteLine(ll.Last.Value);
        Console.WriteLine(ll.Contains("INDIA"));
        foreach(var item in ll)
        {
            Console.WriteLine(item);
        }
    }
}