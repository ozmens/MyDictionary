using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> formalar = new MyDictionary<int, string>();
            formalar.Add(13, "Atiba Hutchinson");
            formalar.Add(14, "Vincent Aboubakar");
            formalar.Add(24, "Domagoj Vida");
            formalar.Add(10, "Sergen Yalçın");
        }

     
    }
}
