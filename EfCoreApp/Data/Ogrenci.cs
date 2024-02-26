﻿namespace EfCoreApp.Data
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        
        public string AdSoyad
        {
            get
            {
                return this.OgrenciAd + " " + this.OgrenciSoyad;
            }
        }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
        public ICollection<KursKayit> KursKayitları { get; set; } = new List<KursKayit>();
    }
}
