

namespace BolalarBogchasi.Data
{
    internal class BogchaDB:DbContext
    {

    private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=BogchaDB;";
    public DbSet<Bolalar> Child { get; set; }
    public DbSet<Haydovchi> Taxi { get; set; }
    public DbSet<Guruh> Group { get; set; }
    public DbSet<Ishlar> Works { get; set; }
    public DbSet<oshpaz> Cook { get; set; }
    public DbSet<Tarbiyachi> Coach { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            AddData(modelBuilder);
        }
        public void AddData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolalar>().HasData(
                new Bolalar()
                {
                    BolaId = 1,
                    BolaIsmi = "Nobody",
                    BolaFamiliyasi = "Nobody",
                    BolagaBoglanishTelRaqami = "+000000000000",
                    BolagaBoglanishElektronPochta = "Email@gmail.com",
                    BolaKelganKun = "01/01/01",
                    BolaBogchadami = true,
                    BolaningManzili ="yunusobod",
                    BolaGuruhi = "guruh1",
                    BolaTolovi = 270000,
                    GuruhId=1,
                    HaydovchiId=1,
                    TarbiyachiId=1,
                }) ;
            modelBuilder.Entity<Guruh>().HasData(
                new Guruh()
                {
                    GuruhId = 1,
                    GuruhNomi = Convert.ToString(Guruhlar.guruh1),
                    Tarbiyachi_id=1,
                });
            modelBuilder.Entity<Haydovchi>().HasData(
                new Haydovchi()
                {
                    HaydovchiManzili= "yunusobod",
                    IshchiBogchadami=true,
                    IshchiElektronPochta="Haydovchi@gmail.com",
                    IshchiFamiliyasi="NoOne",
                    IshchiIsmi="Unknown",
                    IshningNomi= "haydovchi",
                    IshchiKelganKun="01/01/01",
                    IshchiId=1,
                    IshchiMaoshi=4500000,
                    IshchiTelRaqami="+000000000000",
                    IshId=1,
                });
            modelBuilder.Entity<oshpaz>().HasData(
                new oshpaz()
                {
                    IshchiBogchadami = true,
                    IshchiElektronPochta = "oshpaz@gmail.com",
                    IshchiFamiliyasi = "NoOne",
                    IshchiIsmi = "Unknown",
                    IshningNomi = "oshpaz",
                    IshchiKelganKun = "01/01/01",
                    IshchiId = 1,
                    IshchiMaoshi = 4500000,
                    IshchiTelRaqami = "+111111111111",
                    IshId=3,

                });
            modelBuilder.Entity<Tarbiyachi>().HasData(
                new Tarbiyachi()
                {
                    IshchiBogchadami = true,
                    IshchiElektronPochta = "tarbiyachi@gmail.com",
                    IshchiFamiliyasi = "NoOne",
                    IshchiIsmi = "Unknown",
                    IshningNomi = "tarbiyachi",
                    IshchiKelganKun = "01/01/01",
                    IshchiId = 1,
                    IshchiMaoshi = 4500000,
                    IshchiTelRaqami = "+2222222222222",
                    IshId=2,
                    BerilganGuruhNomi="guruh1",

                });
            modelBuilder.Entity<Ishlar>().HasData(
                new Ishlar()
                {
                    Id = 1,
                    Name = "haydovchi",

                },
                new Ishlar()
                {
                    Id = 2,
                    Name = "tarbiyachi",

                },
                new Ishlar()
                {
                    Id = 3,
                    Name = "oshpaz",

                });
        }


    }
}
