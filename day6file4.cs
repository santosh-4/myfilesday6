using System;
using System.Collections.Generic;
class Program
    {
        static void Main()
        {
            //Stack LIFO
            Stack<string> st = new Stack<string>();
            st.Push("kr");
            st.Push("sa");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }
    }