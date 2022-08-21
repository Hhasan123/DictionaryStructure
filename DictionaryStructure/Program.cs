using System;
using System.Collections.Generic;

namespace DictionaryStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var kullanicilar = new Dictionary<int, String>();
            var isimler = new MyDictionary<int, String>();
            Console.WriteLine(isimler.Length);
            isimler.Add(0, "Sifir");
            isimler.Add(1, "Bir");
            isimler.Add(2, "Iki");
            Console.WriteLine(isimler.Length);
            Console.ReadLine();

        }
    }
}
