using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolalarBogchasi.Hodim_o_z_malumotlarini_ko_rishi
{
    public partial class Hodim_Malumotlari : Form
    {
        public HodimViewModel HodimgaKerakliMalumotlari { get; set; }
        public Hodim_Malumotlari()
        {


            InitializeComponent();
        }


        private void Hodim_Malumotlari_Load(object sender, EventArgs e)
        {
            HodimIshkuniSoni.Text = Convert.ToString(HodimgaKerakliMalumotlari.hodimIshlaganKunlariSoni);
            HodimMaoshiningChiqishKuni.Text = HodimgaKerakliMalumotlari.HodimMaoshChiqishKuni.ToString();
            HodimMaoshiningQiymati.Text = Convert.ToString(HodimgaKerakliMalumotlari.HodimMaoshi);


        }

        private void HodimIshkuniSoni_Click(object sender, EventArgs e)
        {

        }
    }
}
