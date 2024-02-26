namespace EfCoreApp.Data
{
    public class KursKayit
    {
        public int KursKayitId { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; } = null!;
        public int KursId { get; set; }
        public Kurs Kurs { get; set; } = null!;
        public DateTime KayitTarih { get; set; }
    }
}
