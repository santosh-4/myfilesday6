using System;
using System.Collections;
class Program
    {
        static void Main()
        {
           ArrayList arrayList = new ArrayList();
           arrayList.Add(1);
           arrayList.Add("sk");
           arrayList.Add('D');
           arrayList.Add(2.2);
           foreach (var item in arrayList)
           {
               Console.WriteLine(item);
           }
        }
    }