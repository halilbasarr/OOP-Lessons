using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bilgi istiyoruz
            Console.Write("Lütfen karesini almak istediğiniz sayıyı girin: ");
            string girilenDeger = Console.ReadLine();

            // Girilen değerin geçerli bir sayı olup olmadığını kontrol ediyoruz (ondalıklı sayılar için double)
            if (double.TryParse(girilenDeger, out double sayi))
            {
                // İşlemi yapan metodu çağırıyoruz ve dönen değeri 'sonuc' değişkenine atıyoruz
                double sonuc = KareAl(sayi);

                // Sonucu ekrana yazdırıyoruz
                Console.WriteLine($"{sayi} sayısının karesi: {sonuc}");
            }
            else
            {
                // Kullanıcı sayı dışında bir karakter girerse uyarı veriyoruz
                Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz!");
            }

            // Ekranın hemen kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.WriteLine("\nÇıkmak için Enter'a basın...");
            Console.ReadLine();
        }
        static double KareAl(double sayi)
        {
            return sayi * sayi;
        }
    }
}