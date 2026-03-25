Random rastgele = new Random();
string harfler = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
string rakamlar = "0123456789";
string ozelKarakterler = "!@#$%^&*()_+-=";

Console.Write("Şifre uzunluğu: ");
int uzunluk = int.Parse(Console.ReadLine()!);

Console.Write("Kaç adet şifre üretilsin? ");
int adet = int.Parse(Console.ReadLine()!);

string tumKarakterler = harfler + rakamlar + ozelKarakterler;

Console.WriteLine($"\n--- Üretilen Şifreler ---\n");
for (int i = 1; i <= adet; i++)
{
    string sifre = "";
    for (int j = 0; j < uzunluk; j++)
    {
        sifre += tumKarakterler[rastgele.Next(tumKarakterler.Length)];
    }
    Console.WriteLine($"  {i}. {sifre}");
}
