using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolalarBogchasi.Bolalar_malumotlar_ota_ona_uchun
{
    public partial class BolalarMalumotlariOtaOnalarga : Form
    {
        public BolaViewModel OtaOnagaFarzandiHaqidaMalumot { get; set; }
        public BolalarMalumotlariOtaOnalarga()
        {
            InitializeComponent();
        }

        private void BolalarMalumotlariOtaOnalarga_Load(object sender, EventArgs e)
        {
            BogchaToloviQiymati.Text = OtaOnagaFarzandiHaqidaMalumot.BolaningQolganQarzi.ToString();
            
            BolaQarziniQolganQismi.Text = OtaOnagaFarzandiHaqidaMalumot.bolaToloviOylik.ToString();

            TarbiyachiningIsmi.Text = OtaOnagaFarzandiHaqidaMalumot.BolagaBogchadaMasulShaxsIsmi.ToString();
            BolaTolovKuni.Text = OtaOnagaFarzandiHaqidaMalumot.QarzniTolashniOxirgiMuddati.ToString();
        }

        private void JonatishSavolVaShikoyatni_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xabaringiz qabul qilindi");
            textBox1.Text = "";
        }
    }
}
