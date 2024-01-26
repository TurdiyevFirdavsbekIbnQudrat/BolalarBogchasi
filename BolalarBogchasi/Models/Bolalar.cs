

namespace BolalarBogchasi.Models
{
    internal class Bolalar
    {
        
        [Key]
        public int BolaId { get; set; }
        public string BolaGuruhi { get; set; }
        public string BolaningManzili { get; set; }
        public string BolaIsmi { get; set; }
        public string BolaFamiliyasi { get; set; }
        public string BolaKelganKun { get; set; }
        public string BolagaBoglanishTelRaqami { get; set; }
        public string BolagaBoglanishElektronPochta { get; set; }
        public bool BolaBogchadami { get; set; } = true;
        public long BolaTolovi { get; set; }

        public int GuruhId { get; set; }
        public Guruh Guruh { get; set; }

        [ForeignKey(nameof(Haydovchi))]
        public int HaydovchiId { get; set; }
        public Haydovchi Haydovchi { get; set; }

        [ForeignKey(nameof(Tarbiyachi))]
        public int TarbiyachiId { get; set; }
        public Tarbiyachi Tarbiyachi { get; set; }

    }
}
