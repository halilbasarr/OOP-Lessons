namespace YapilacaklarListesi.Models
{
    // Tek bir görevi temsil eden sınıf
    public class Gorev
    {
        public int Id { get; set; }
        public string Baslik { get; set; } = string.Empty;
        public string Aciklama { get; set; } = string.Empty;
        public GorevDurumu Durum { get; set; } = GorevDurumu.Beklemede;
        public OncelikSeviyesi Oncelik { get; set; } = OncelikSeviyesi.Orta;
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public DateTime? TamamlanmaTarihi { get; set; }

        // Görev bilgilerini formatlı döndürür
        public override string ToString()
        {
            string durumEtiketi = Durum switch
            {
                GorevDurumu.Beklemede => "[Beklemede]",
                GorevDurumu.DevamEdiyor => "[Devam Ediyor]",
                GorevDurumu.Tamamlandi => "[Tamamlandi]",
                _ => "[?]"
            };

            string oncelikEtiketi = Oncelik switch
            {
                OncelikSeviyesi.Dusuk => "(Dusuk)",
                OncelikSeviyesi.Orta => "(Orta)",
                OncelikSeviyesi.Yuksek => "(Yuksek)",
                OncelikSeviyesi.Acil => "(Acil)",
                _ => "(-)"
            };

            return $"  {durumEtiketi} [{Id}] {Baslik} {oncelikEtiketi}" +
                   $"\n       Açıklama: {Aciklama}" +
                   $"\n       Oluşturulma: {OlusturulmaTarihi:dd.MM.yyyy HH:mm}" +
                   (TamamlanmaTarihi.HasValue ? $"\n       Tamamlanma: {TamamlanmaTarihi:dd.MM.yyyy HH:mm}" : "");
        }
    }
}
