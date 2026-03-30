using System.Text.Json;
using YapilacaklarListesi.Models;

namespace YapilacaklarListesi.Services
{
    // JSON dosya kaydetme ve yükleme işlemleri
    public class DosyaYoneticisi
    {
        private readonly string _dosyaYolu;

        public DosyaYoneticisi(string dosyaAdi = "gorevler.json")
        {
            string dizin = AppDomain.CurrentDomain.BaseDirectory;
            _dosyaYolu = Path.Combine(dizin, dosyaAdi);
        }

        // Görevleri JSON olarak kaydeder
        public void Kaydet(List<Gorev> gorevler)
        {
            var ayarlar = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = null
            };

            string json = JsonSerializer.Serialize(gorevler, ayarlar);
            File.WriteAllText(_dosyaYolu, json);
        }

        // JSON dosyasından görevleri yükler
        public List<Gorev> Yukle()
        {
            if (!File.Exists(_dosyaYolu))
                return new List<Gorev>();

            try
            {
                string json = File.ReadAllText(_dosyaYolu);
                return JsonSerializer.Deserialize<List<Gorev>>(json) ?? new List<Gorev>();
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Dosya okunurken hata: {ex.Message}");
                return new List<Gorev>();
            }
        }
    }
}
