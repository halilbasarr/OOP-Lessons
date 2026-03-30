# 📋 Yapılacaklar Listesi - C# Console Uygulaması

Görevlerinizi yönetebileceğiniz, C# ile geliştirilmiş interaktif bir konsol uygulaması.

## ✨ Özellikler

- ✅ **Görev Ekleme** — Başlık, açıklama ve öncelik seviyesi ile yeni görev oluşturma
- 📋 **Listeleme** — Tüm görevleri detaylı şekilde görüntüleme
- 🔄 **Durum Güncelleme** — Beklemede / Devam Ediyor / Tamamlandı
- 🗑️ **Silme** — Onaylı görev silme
- 📊 **Öncelik Sıralama** — LINQ ile önceliğe göre sıralama
- 🔍 **Arama** — Başlık ve açıklama içinde arama
- 📈 **İstatistikler** — İlerleme çubuğu ile tamamlanma yüzdesi
- 💾 **JSON Kaydetme** — Görevler otomatik olarak JSON dosyasına kaydedilir

## 🛠️ Kullanılan Teknolojiler & Kavramlar

| Kavram | Açıklama |
|--------|----------|
| **OOP** | Sınıflar, özellikler (properties), metotlar |
| **Enum** | `GorevDurumu`, `OncelikSeviyesi` |
| **LINQ** | `Where`, `OrderBy`, `Count`, `FirstOrDefault` |
| **JSON Serileştirme** | `System.Text.Json` ile dosya okuma/yazma |
| **Switch Expressions** | Modern C# pattern matching |
| **Nullable Types** | `DateTime?`, `string?` kullanımı |
| **Tuples** | İstatistik döndürme için named tuple |
| **String Interpolation** | Formatlı metin çıktıları |

## 📂 Proje Yapısı

```
yapilacaklar-listesi/
├── Models/
│   ├── Gorev.cs              # Görev model sınıfı
│   ├── GorevDurumu.cs        # Durum enum'ı
│   └── OncelikSeviyesi.cs    # Öncelik enum'ı
├── Services/
│   ├── GorevYoneticisi.cs    # İş mantığı (CRUD + LINQ)
│   └── DosyaYoneticisi.cs    # JSON dosya işlemleri
├── Program.cs                # Ana uygulama ve menü
└── README.md
```

## 🚀 Çalıştırma

```bash
dotnet run
```

## 📸 Ekran Görüntüsü

```
    ╔══════════════════════════════════════════════════╗
    ║                                                  ║
    ║    📋  YAPILACAKLAR LİSTESİ  📋                 ║
    ║    ─────────────────────────────                  ║
    ║    C# Console Uygulaması                         ║
    ║    OOP • LINQ • JSON Dosya İşlemleri             ║
    ║                                                  ║
    ╚══════════════════════════════════════════════════╝

╔══════════════════════════════════════════╗
║           📋 ANA MENÜ                    ║
╠══════════════════════════════════════════╣
║  1 → Yeni Görev Ekle                    ║
║  2 → Tüm Görevleri Listele              ║
║  3 → Görev Durumu Güncelle               ║
║  4 → Görev Sil                          ║
║  5 → Önceliğe Göre Sırala               ║
║  6 → Duruma Göre Filtrele                ║
║  7 → Görev Ara                          ║
║  8 → İstatistikler                      ║
║  0 → Çıkış                              ║
╚══════════════════════════════════════════╝
```

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.
