


namespace BolalarBogchasi.Models
{
    internal class Tarbiyachi : IshchiMalumoti
    {
        [Key]
        public int IshchiId { get; set; }

        public string BerilganGuruhNomi { get; set; }
        
        public string IshningNomi { get; set; }
        public string IshchiIsmi { get; set; }
        public string IshchiFamiliyasi { get; set; }
        public string IshchiKelganKun { get; set; }
        public string IshchiTelRaqami { get; set; }
        public string IshchiElektronPochta { get; set; }
        public int IshchiMaoshi { get; set; }
        public bool IshchiBogchadami { get; set; }
        public ICollection<Bolalar> Bola_tarbiyachi { get; set; }
        public ICollection<Guruh> guruh_tarbiyachi { get; set; }

        [ForeignKey(nameof(Ishlar))]
        public int IshId { get; set; }
        public Ishlar Ishlar { get; set; }
    }
}
