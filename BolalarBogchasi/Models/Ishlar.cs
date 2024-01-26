
namespace BolalarBogchasi.Models
{
    internal class Ishlar
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Haydovchi> Haydovchi_ish { get; set; }
        public ICollection<oshpaz> oshpazlar_ish { get; set; }
        public ICollection<Tarbiyachi> tarbiyachi_ish { get; set; }

    }
}
