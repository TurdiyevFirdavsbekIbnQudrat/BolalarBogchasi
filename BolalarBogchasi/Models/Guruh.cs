

namespace BolalarBogchasi.Models
{
    internal class Guruh
    {
        [Key]
        public int  GuruhId { get; set; }
        public string GuruhNomi { get; set; }

        public ICollection<Bolalar> Bola_guruhga { get; set; }
        [ForeignKey(nameof(Tarbiyachi))]
        public int Tarbiyachi_id { get; set; }
        public Tarbiyachi Tarbiyachi { get; set; }
    }
}
