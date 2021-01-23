using System;

namespace Ödev___4._Gün
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ArabaMarkaları = new MyDictionary<int, string>();
            ArabaMarkaları.Add(1,"Mercedes");
            ArabaMarkaları.Add(2, "BMW");
            ArabaMarkaları.Add(3, "Volvo");
            ArabaMarkaları.Add(4, "Honda");
            ArabaMarkaları.Add(5, "Hyundai");
            ArabaMarkaları.Add(6, "Renault");

            for (int i = 0; i <ArabaMarkaları.key.Length; i++)
            {
                Console.WriteLine("Araba Numarası" + " " + ArabaMarkaları.key[i]);
                Console.WriteLine("Araba Markası" + " " +  ArabaMarkaları.value[i]);
                Console.WriteLine("------------------------------------------");

            }

        }
    }
}
