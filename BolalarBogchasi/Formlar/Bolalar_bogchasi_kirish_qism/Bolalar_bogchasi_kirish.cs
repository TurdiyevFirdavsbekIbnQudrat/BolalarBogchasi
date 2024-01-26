
using BolalarBogchasi.Bolalar_malumotlar_ota_ona_uchun;
using BolalarBogchasi.Boshqaruvchi;
using BolalarBogchasi.Formlar.Boshqaruvchi;
using BolalarBogchasi.Formlar.Idni_Unutdingizmi;
using BolalarBogchasi.Malumotlarni_qo_shish;

namespace BolalarBogchasi
{
    public partial class Bolalar_bogchasi_kirish : Form
    {
        public Bolalar_bogchasi_kirish()
        {

            InitializeComponent();
        }
        // private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=BogchaDB;";

        private void IDningKirishdaTextBoxi_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void MalumotlarBerdi_Click(object sender, EventArgs e)
        {

            if ("login" == IDningKirishdaTextBoxi.Text && "admin" == TelefonRaqamKirishda.Text)
            {
                    var bf = new Oraliq();
                    bf.Show();
                
               

            }

            else
            {
                int AzoId = -1;
                bool isProbelExist = false;
                bool isMessageBoxWork = false;
                bool isTrueNumber = true;

                try
                {
                    AzoId = Convert.ToInt32(IDningKirishdaTextBoxi.Text);

                }
                catch
                {
                    isMessageBoxWork = true;
                    MessageBox.Show("Id yoki Telefon Raqam xato kiritildi ");
                }

                string telefonRaqam = TelefonRaqamKirishda.Text;

                for (int i = 0; i < telefonRaqam.Length; i++)
                {
                    if (telefonRaqam[i] == ' ')
                    {
                        isProbelExist = true;
                        break;
                    }
                }
                if (telefonRaqam[0] == '+'
                    && telefonRaqam[1] == '9'
                    && telefonRaqam[2] == '9'
                    && telefonRaqam[3] == '8'
                    && telefonRaqam.Length==13)
                {
                    
                    for (int i = 4; i < telefonRaqam.Length; i++)
                    {
                        if (telefonRaqam[i] < 48 || telefonRaqam[i] > 58) { isTrueNumber = false; }
                    }
                }

                if (isMessageBoxWork == false && isTrueNumber == false)
                {
                    string s = "Id yoki Telefon Raqam xato kiritildi";
                    if (isProbelExist == true) { s = "Probeldan foydalanmang!!!"; }

                    MessageBox.Show(s);
                }
                int count = 0;
                if (isMessageBoxWork == false && isTrueNumber == true && isProbelExist == false)
                {
                    using (var context = new BogchaDB())
                    {
                        
                        var blog = context.Taxi.
                            Where(b => b.IshchiTelRaqami.Equals(telefonRaqam)).
                            Where(c => c.IshchiId == AzoId).
                            Where(d => d.IshchiBogchadami == true).
                            ToList();

                        if (blog.Count != 0)
                        {

                            count++;
                            var obj = new Hodim_Malumotlari();
                            obj.HodimgaKerakliMalumotlari = new HodimViewModel();
                            obj.HodimgaKerakliMalumotlari.HodimMaoshi = blog[0].IshchiMaoshi;
                            obj.HodimgaKerakliMalumotlari.HodimMaoshChiqishKuni = blog[0].IshchiKelganKun;
                            obj.HodimgaKerakliMalumotlari.hodimIshlaganKunlariSoni = 12;
                            obj.Show();

                        }
                        var blog1 = context.Coach.
                            Where(b => b.IshchiTelRaqami.Equals(telefonRaqam)).
                            Where(c => c.IshchiId == AzoId).
                            Where(d => d.IshchiBogchadami == true).
                            ToList();

                        if (blog1.Count != 0)
                        {
                            count++;
                            var obj = new Hodim_Malumotlari();
                            obj.HodimgaKerakliMalumotlari = new HodimViewModel();
                            obj.HodimgaKerakliMalumotlari.HodimMaoshi = blog1[0].IshchiMaoshi;
                            obj.HodimgaKerakliMalumotlari.HodimMaoshChiqishKuni = blog1[0].IshchiKelganKun;
                            obj.HodimgaKerakliMalumotlari.hodimIshlaganKunlariSoni = 12;
                            obj.Show();
                        }
                        var blog2 = context.Cook.
                            Where(b => b.IshchiTelRaqami.Equals(telefonRaqam)).
                            Where(c => c.IshchiId == AzoId).
                            Where(d => d.IshchiBogchadami == true).
                            ToList();

                        if (blog2.Count != 0)
                        {
                            count++;
                            var obj = new Hodim_Malumotlari();
                            obj.HodimgaKerakliMalumotlari = new HodimViewModel();
                            obj.HodimgaKerakliMalumotlari.HodimMaoshi = blog2[0].IshchiMaoshi;
                            obj.HodimgaKerakliMalumotlari.HodimMaoshChiqishKuni = blog2[0].IshchiKelganKun;
                            obj.HodimgaKerakliMalumotlari.hodimIshlaganKunlariSoni = 12;
                            obj.Show();

                        }
                        var blog3 = context.Child.
                            Where(b => b.BolagaBoglanishTelRaqami.Equals(telefonRaqam)).
                            Where(c => c.BolaId == AzoId).
                            Where(d => d.BolaBogchadami == true).
                            ToList();

                        if (blog3.Count != 0)
                        {
                            count++;
                            var bolaDataForm = new BolalarMalumotlariOtaOnalarga();
                            bolaDataForm.OtaOnagaFarzandiHaqidaMalumot = new BolaViewModel();
                            string bolaGri = blog3[0].BolaGuruhi;
                            bolaDataForm.OtaOnagaFarzandiHaqidaMalumot.BolagaBogchadaMasulShaxsIsmi =
                                context.Coach.Where(a => a.BerilganGuruhNomi == bolaGri).ToList()[0].IshchiIsmi;
                            bolaDataForm.OtaOnagaFarzandiHaqidaMalumot.BolaningQolganQarzi = 270000;
                            bolaDataForm.OtaOnagaFarzandiHaqidaMalumot.QarzniTolashniOxirgiMuddati = "30/10/2023";
                            bolaDataForm.OtaOnagaFarzandiHaqidaMalumot.bolaToloviOylik = blog3[0].BolaTolovi;
                            bolaDataForm.Show();

                        }
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Id yoki Telefon Raqam xato kiritildi ");
                    }

                }

            }
        }

        private void Bolalar_bogchasi_kirish_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void KirishTekshiruvi_Click(object sender, EventArgs e)
        {
            var IU = new Idni_unutdingizmi();
            IU.Show();
            this.Hide();
        }
    }
}