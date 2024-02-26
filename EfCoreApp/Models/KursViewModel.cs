using EfCoreApp.Data;
using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Models
{
    public class KursViewModel
    {
        public int KursId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Baslik { get; set; }
        [Required]
        public int? OgretmenId { get; set; }
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}
