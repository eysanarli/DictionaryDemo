using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> burclar = new MyDictionary<string, int>();

            burclar.Add(1, "Koç Burcu : 21 Mart – 20 Nisan");
            burclar.Add(2, "Boğa Burcu : 21 Nisan – 21 Mayıs");
            burclar.Add(3, "İkizler Burcu : 22 Mayıs – 22 Haziran");
            burclar.Add(4, "Yengeç Burcu : 22 Haziran – 22 Temmuz");
            burclar.Add(5, "Aslan Burcu : 23 Temmuz – 22 Ağustos");
            burclar.Add(6, "Başak Burcu : 23 Ağustos – 22 Eylül");
            burclar.Add(7, "Terazi Burcu : 23 Eylül – 22 Ekim");
            burclar.Add(8, "Akrep Burcu : 23 Ekim – 21 Kasım");
            burclar.Add(9, "Yay Burcu : 22 Kasım – 21 Aralık");
            burclar.Add(10, "Oğlak Burcu : 22 Aralık – 21 Ocak");
            burclar.Add(11, "Kova Burcu : 22 Ocak – 19 Şubat");
            burclar.Add(12, "Balık Burcu : 20 Şubat – 20 Mart");


            for (int i = 0; i < burclar.Keys.Length; i++)
            {
                Console.WriteLine("Key: " + burclar.Keys[i] + "\tValue: " + burclar.Values[i]);
                Console.WriteLine();
            }
        }
    }
}

