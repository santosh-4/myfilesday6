
using System;
using System.Collections.Generic;
class Program
    {
        static void Main()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();
            for (int i=0;i<str.Length;i++)
            {
                int count = 0;
                foreach (char c in str)
                {
                    if (c == str[i])
                    {
                        count++;
                    }
                }
                if (!d.ContainsKey(str[i]))
                {
                    d.Add(str[i], count);
                }
            }
            foreach (var item in d)
            {
                Console.WriteLine("Key = " + item.Key + "; Value = " + item.Value);
            }
        }
    }