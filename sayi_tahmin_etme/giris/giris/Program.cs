using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();

            int hedefSayi = rastgele.Next(1,101);
            int hak = 10;

            Console.WriteLine("1 ile 100 arasındaki sayıyı bakalım bilecek misin?");

            while (hak > 0)
            {
                Console.WriteLine($"\nKalan hakkın:{hak}. Tahminin: ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out int tahmin))
                {
                    if (tahmin == hedefSayi)
                    {
                        Console.WriteLine("Tebrikler! Doğru bildin.");
                    }
                    else if (tahmin != hedefSayi)
                    {
                        Console.WriteLine("Bir daha dene.");
                    }

                    hak--;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }
            }

            if (hak == 0) Console.WriteLine($"Üzgünüm, kaybettin! Bilmen gerek sayı buydu: {hedefSayi}");
        }
    }
}
