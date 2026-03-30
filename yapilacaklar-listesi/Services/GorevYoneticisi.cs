using YapilacaklarListesi.Models;

namespace YapilacaklarListesi.Services
{
    // Görev CRUD ve LINQ sorgu işlemleri
    public class GorevYoneticisi
    {
        private List<Gorev> _gorevler;
        private readonly DosyaYoneticisi _dosyaYoneticisi;
        private int _sonrakiId;

        public GorevYoneticisi()
        {
            _dosyaYoneticisi = new DosyaYoneticisi();
            _gorevler = _dosyaYoneticisi.Yukle();
            _sonrakiId = _gorevler.Count > 0 ? _gorevler.Max(g => g.Id) + 1 : 1;
        }

        // Yeni görev ekler ve kaydeder
        public Gorev GorevEkle(string baslik, string aciklama, OncelikSeviyesi oncelik)
        {
            var yeniGorev = new Gorev
            {
                Id = _sonrakiId++,
                Baslik = baslik,
                Aciklama = aciklama,
                Oncelik = oncelik,
                Durum = GorevDurumu.Beklemede,
                OlusturulmaTarihi = DateTime.Now
            };

            _gorevler.Add(yeniGorev);
            Kaydet();
            return yeniGorev;
        }

        // ID'ye göre görev siler
        public bool GorevSil(int id)
        {
            var gorev = _gorevler.FirstOrDefault(g => g.Id == id);
            if (gorev == null) return false;

            _gorevler.Remove(gorev);
            Kaydet();
            return true;
        }

        // Durum günceller, tamamlandıysa tarihi ayarlar
        public bool DurumGuncelle(int id, GorevDurumu yeniDurum)
        {
            var gorev = _gorevler.FirstOrDefault(g => g.Id == id);
            if (gorev == null) return false;

            gorev.Durum = yeniDurum;

            if (yeniDurum == GorevDurumu.Tamamlandi)
                gorev.TamamlanmaTarihi = DateTime.Now;
            else
                gorev.TamamlanmaTarihi = null;

            Kaydet();
            return true;
        }

        // Tüm görevleri döndürür
        public List<Gorev> TumGorevler() => _gorevler;

        // Duruma göre filtreler
        public List<Gorev> DurumaGoreFiltrele(GorevDurumu durum)
        {
            return _gorevler.Where(g => g.Durum == durum).ToList();
        }

        // Önceliğe göre filtreler
        public List<Gorev> OncelligeGoreFiltrele(OncelikSeviyesi oncelik)
        {
            return _gorevler.Where(g => g.Oncelik == oncelik).ToList();
        }

        // Önceliğe göre sıralar (yüksek önce)
        public List<Gorev> OncelligeGoreSirala()
        {
            return _gorevler
                .OrderByDescending(g => g.Oncelik)
                .ThenBy(g => g.OlusturulmaTarihi)
                .ToList();
        }

        // Başlık/açıklamada arama yapar
        public List<Gorev> Ara(string aramaMetni)
        {
            return _gorevler
                .Where(g => g.Baslik.Contains(aramaMetni, StringComparison.OrdinalIgnoreCase) ||
                            g.Aciklama.Contains(aramaMetni, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Görev istatistiklerini döndürür
        public (int Toplam, int Beklemede, int DevamEdiyor, int Tamamlandi) IstatistikleriGetir()
        {
            return (
                Toplam: _gorevler.Count,
                Beklemede: _gorevler.Count(g => g.Durum == GorevDurumu.Beklemede),
                DevamEdiyor: _gorevler.Count(g => g.Durum == GorevDurumu.DevamEdiyor),
                Tamamlandi: _gorevler.Count(g => g.Durum == GorevDurumu.Tamamlandi)
            );
        }

        // Tamamlanma yüzdesini hesaplar
        public double TamamlanmaYuzdesi()
        {
            if (_gorevler.Count == 0) return 0;
            return Math.Round((_gorevler.Count(g => g.Durum == GorevDurumu.Tamamlandi) * 100.0) / _gorevler.Count, 1);
        }

        private void Kaydet() => _dosyaYoneticisi.Kaydet(_gorevler);
    }
}
