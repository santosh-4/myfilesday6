using System;
using System.Collections;
class Program
    {
        static void Main()
        {
           Hashtable g = new Hashtable();
           g.Add(1, "Welcome");
           g.Add(2, "to");
           g.Add(3, "C Sharp");
           g.Add(4, "Class");
           ICollection key = g.Keys;
           foreach (var item in key)
           {
               Console.WriteLine(item+"_"+g[item]);
           }
        }
    }