using System.Text;
using YapilacaklarListesi.Models;
using YapilacaklarListesi.Services;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

var yonetici = new GorevYoneticisi();

BaslikYazdir();
AnaMenu();

// Ana Menü
void AnaMenu()
{
    while (true)
    {
        Console.WriteLine("\n╔══════════════════════════════════════════╗");
        Console.WriteLine("║             ANA MENU                     ║");
        Console.WriteLine("╠══════════════════════════════════════════╣");
        Console.WriteLine("║  1 → Yeni Görev Ekle                    ║");
        Console.WriteLine("║  2 → Tüm Görevleri Listele              ║");
        Console.WriteLine("║  3 → Görev Durumu Güncelle               ║");
        Console.WriteLine("║  4 → Görev Sil                          ║");
        Console.WriteLine("║  5 → Önceliğe Göre Sırala               ║");
        Console.WriteLine("║  6 → Duruma Göre Filtrele                ║");
        Console.WriteLine("║  7 → Görev Ara                          ║");
        Console.WriteLine("║  8 → İstatistikler                      ║");
        Console.WriteLine("║  0 → Çıkış                              ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");
        Console.Write("\n  Seçiminiz > ");

        string? secim = Console.ReadLine();

        switch (secim)
        {
            case "1": YeniGorevEkle(); break;
            case "2": GorevleriListele(); break;
            case "3": DurumGuncelle(); break;
            case "4": GorevSil(); break;
            case "5": OncelligeGoreSirala(); break;
            case "6": DurumaGoreFiltrele(); break;
            case "7": GorevAra(); break;
            case "8": IstatistikleriGoster(); break;
            case "0":
                Console.WriteLine("\n  Güle güle! Görevlerini unutma!");
                return;
            default:
                Console.WriteLine("\n  Geçersiz seçim, tekrar deneyin.");
                break;
        }
    }
}

// Yeni Görev Ekle
void YeniGorevEkle()
{
    Console.WriteLine("\n  -- Yeni Görev Ekle ----------------------");

    Console.Write("  Başlık: ");
    string baslik = Console.ReadLine()?.Trim() ?? "";
    if (string.IsNullOrEmpty(baslik))
    {
        Console.WriteLine("  Başlık boş olamaz!");
        return;
    }

    Console.Write("  Açıklama: ");
    string aciklama = Console.ReadLine()?.Trim() ?? "";

    Console.WriteLine("  Öncelik seçin:");
    Console.WriteLine("    1 - Düşük");
    Console.WriteLine("    2 - Orta");
    Console.WriteLine("    3 - Yüksek");
    Console.WriteLine("    4 - Acil");
    Console.Write("  > ");

    OncelikSeviyesi oncelik = Console.ReadLine() switch
    {
        "1" => OncelikSeviyesi.Dusuk,
        "2" => OncelikSeviyesi.Orta,
        "3" => OncelikSeviyesi.Yuksek,
        "4" => OncelikSeviyesi.Acil,
        _ => OncelikSeviyesi.Orta
    };

    var gorev = yonetici.GorevEkle(baslik, aciklama, oncelik);
    Console.WriteLine($"\n  Görev #{gorev.Id} başarıyla eklendi!");
}

// Görevleri Listele
void GorevleriListele()
{
    var gorevler = yonetici.TumGorevler();

    if (gorevler.Count == 0)
    {
        Console.WriteLine("\n  Henüz görev eklenmemiş.");
        return;
    }

    Console.WriteLine($"\n  -- Tüm Görevler ({gorevler.Count} adet) ----------");
    Console.WriteLine(new string('─', 50));

    foreach (var gorev in gorevler)
    {
        Console.WriteLine(gorev);
        Console.WriteLine(new string('─', 50));
    }
}

// Durum Güncelle
void DurumGuncelle()
{
    GorevleriListele();

    Console.Write("\n  Güncellenecek görev ID: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("  Geçersiz ID!");
        return;
    }

    Console.WriteLine("  Yeni durumu seçin:");
    Console.WriteLine("    1 - Beklemede");
    Console.WriteLine("    2 - Devam Ediyor");
    Console.WriteLine("    3 - Tamamlandı");
    Console.Write("  > ");

    GorevDurumu? yeniDurum = Console.ReadLine() switch
    {
        "1" => GorevDurumu.Beklemede,
        "2" => GorevDurumu.DevamEdiyor,
        "3" => GorevDurumu.Tamamlandi,
        _ => null
    };

    if (yeniDurum == null)
    {
        Console.WriteLine("  Geçersiz seçim!");
        return;
    }

    if (yonetici.DurumGuncelle(id, yeniDurum.Value))
        Console.WriteLine($"  Görev #{id} güncellendi!");
    else
        Console.WriteLine($"  Görev #{id} bulunamadı!");
}

// Görev Sil
void GorevSil()
{
    GorevleriListele();

    Console.Write("\n  Silinecek görev ID: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("  Geçersiz ID!");
        return;
    }

    Console.Write($"  Görev #{id} silinecek. Emin misiniz? (e/h): ");
    if (Console.ReadLine()?.ToLower() == "e")
    {
        if (yonetici.GorevSil(id))
            Console.WriteLine($"  Görev #{id} silindi!");
        else
            Console.WriteLine($"  Görev #{id} bulunamadı!");
    }
    else
    {
        Console.WriteLine("  İşlem iptal edildi.");
    }
}

// Önceliğe Göre Sırala
void OncelligeGoreSirala()
{
    var gorevler = yonetici.OncelligeGoreSirala();

    if (gorevler.Count == 0)
    {
        Console.WriteLine("\n  Henüz görev eklenmemiş.");
        return;
    }

    Console.WriteLine("\n  -- Önceliğe Göre Sıralı -----------------");
    Console.WriteLine(new string('─', 50));

    foreach (var gorev in gorevler)
    {
        Console.WriteLine(gorev);
        Console.WriteLine(new string('─', 50));
    }
}

// Duruma Göre Filtrele
void DurumaGoreFiltrele()
{
    Console.WriteLine("\n  Filtrelenecek durumu seçin:");
    Console.WriteLine("    1 - Beklemede");
    Console.WriteLine("    2 - Devam Ediyor");
    Console.WriteLine("    3 - Tamamlandı");
    Console.Write("  > ");

    GorevDurumu? durum = Console.ReadLine() switch
    {
        "1" => GorevDurumu.Beklemede,
        "2" => GorevDurumu.DevamEdiyor,
        "3" => GorevDurumu.Tamamlandi,
        _ => null
    };

    if (durum == null)
    {
        Console.WriteLine("  Geçersiz seçim!");
        return;
    }

    var gorevler = yonetici.DurumaGoreFiltrele(durum.Value);

    if (gorevler.Count == 0)
    {
        Console.WriteLine($"\n  \"{durum}\" durumunda görev bulunamadı.");
        return;
    }

    Console.WriteLine($"\n  -- {durum} Görevler ({gorevler.Count} adet) ------");
    Console.WriteLine(new string('─', 50));

    foreach (var gorev in gorevler)
    {
        Console.WriteLine(gorev);
        Console.WriteLine(new string('─', 50));
    }
}

// Görev Ara
void GorevAra()
{
    Console.Write("\n  Arama metni: ");
    string? aramaMetni = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(aramaMetni))
    {
        Console.WriteLine("  Arama metni boş olamaz!");
        return;
    }

    var sonuclar = yonetici.Ara(aramaMetni);

    if (sonuclar.Count == 0)
    {
        Console.WriteLine($"  \"{aramaMetni}\" için sonuç bulunamadı.");
        return;
    }

    Console.WriteLine($"\n  -- Arama Sonuçları: \"{aramaMetni}\" ({sonuclar.Count} sonuç) --");
    Console.WriteLine(new string('─', 50));

    foreach (var gorev in sonuclar)
    {
        Console.WriteLine(gorev);
        Console.WriteLine(new string('─', 50));
    }
}

// İstatistikler
void IstatistikleriGoster()
{
    var (toplam, beklemede, devamEdiyor, tamamlandi) = yonetici.IstatistikleriGetir();
    double yuzde = yonetici.TamamlanmaYuzdesi();

    Console.WriteLine("\n╔══════════════════════════════════════════╗");
    Console.WriteLine("║           ISTATISTIKLER                  ║");
    Console.WriteLine("╠══════════════════════════════════════════╣");
    Console.WriteLine($"║  Toplam Görev     : {toplam,-21}║");
    Console.WriteLine($"║  Beklemede        : {beklemede,-21}║");
    Console.WriteLine($"║  Devam Ediyor     : {devamEdiyor,-21}║");
    Console.WriteLine($"║  Tamamlandı       : {tamamlandi,-21}║");
    Console.WriteLine("╠══════════════════════════════════════════╣");

    // İlerleme çubuğu
    int doluKisim = (int)(yuzde / 5);
    string ilerlemeCubugu = new string('█', doluKisim) + new string('░', 20 - doluKisim);
    Console.WriteLine($"║  İlerleme: [{ilerlemeCubugu}] {yuzde}%  ║");
    Console.WriteLine("╚══════════════════════════════════════════╝");
}

// Başlık
void BaslikYazdir()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
    ╔══════════════════════════════════════════════════╗
    ║                                                  ║
    ║       YAPILACAKLAR LISTESI                       ║
    ║    ─────────────────────────────                  ║
    ║    C# Console Uygulaması                         ║
    ║    OOP - LINQ - JSON Dosya İşlemleri             ║
    ║                                                  ║
    ╚══════════════════════════════════════════════════╝
    ");
    Console.ResetColor();
}
