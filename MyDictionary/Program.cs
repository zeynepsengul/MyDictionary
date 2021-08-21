using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(12, "Zeynep");
        }
    }
}
