using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1 den başlayarak console dan girilen sayıya kadar(sayı dahil)ortalama hesaplama
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            if (sayi > 0)
            {
                Console.WriteLine(toplam / sayi);
            }
            else
                Console.WriteLine("Sıfır ve sıfırdan küçük sayı giremezsiniz!");
            // 'a' dan 'z'ye kadar tüm harfleri console yazdır.

            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("*****Foreach******");

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
