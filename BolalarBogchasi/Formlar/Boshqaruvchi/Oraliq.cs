

using BolalarBogchasi.Boshqaruvchi;
using BolalarBogchasi.Malumotlarni_qo_shish;
using BolalarBogchasi.Override;

namespace BolalarBogchasi.Formlar.Boshqaruvchi
{
    public partial class Oraliq : Form
    {
        public Oraliq()
        {
            InitializeComponent();
        }

        private void TolovMalumotlariga_Click(object sender, EventArgs e)
        {
            var oraliqqa = new tolovqilindi();
            oraliqqa.Show();
            this.Hide();
        }
        Hisobot2 xabar2 = new Hisobot2();
        Xisobot Xabar = new Xisobot();
        private void BolaMalumotlariga_Click(object sender, EventArgs e)
        {

            xabar2.Hisobot();
            var oraliqqa = new MalumotQoshish();
            oraliqqa.Show();
            this.Hide();
        }

        private void HodimMalumotlariga_Click(object sender, EventArgs e)
        {
            Xabar.Hisobot();
            var oraliqqa = new Boshqaruvvchi();
            oraliqqa.Show();
            this.Hide();

        }

        private void Oraliq_Load(object sender, EventArgs e)
        {

        }
    }
}
