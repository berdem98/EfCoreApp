using Microsoft.EntityFrameworkCore;

namespace EfCoreApp.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
        }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<KursKayit> KursKayitlari { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
    }
}
