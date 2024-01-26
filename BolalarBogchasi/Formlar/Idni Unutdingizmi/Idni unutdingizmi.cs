using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolalarBogchasi.Formlar.Idni_Unutdingizmi
{
    public partial class Idni_unutdingizmi : Form
    {
        public Idni_unutdingizmi()
        {
            InitializeComponent();
        }

        private void RaqamniJonatish_Click(object sender, EventArgs e)
        {
            int checkIsExistPhoneNumber=-1;
            if (comboBox1.Text == "haydovchi")
            {
                using (var context = new BogchaDB())
                {
                     checkIsExistPhoneNumber = context.Taxi.
                         Where(c => c.IshchiTelRaqami == RaqamniKiritishIdOLishgaTextBox.Text).
                         Where(d => d.IshchiBogchadami == true).
                         ToList()[0].IshchiId;
                }
            }
            if (comboBox1.Text == "tarbiyachi")
            {
                using (var context = new BogchaDB())
                {
                     checkIsExistPhoneNumber = context.Coach.
                         Where(c => c.IshchiTelRaqami == RaqamniKiritishIdOLishgaTextBox.Text).
                         Where(d => d.IshchiBogchadami == true).
                         ToList()[0].IshchiId;
                }
            }
            if (comboBox1.Text == "oshpaz")
            {
                using (var context = new BogchaDB())
                {
                     checkIsExistPhoneNumber = context.Cook.
                         Where(c => c.IshchiTelRaqami == RaqamniKiritishIdOLishgaTextBox.Text).
                         Where(d => d.IshchiBogchadami == true).
                         ToList()[0].IshchiId;
                }
            }
            if (comboBox1.Text == "Bola")
            {
                using (var context = new BogchaDB())
                {
                     checkIsExistPhoneNumber = context.Child.
                         Where(c => c.BolagaBoglanishTelRaqami == RaqamniKiritishIdOLishgaTextBox.Text).
                         Where(d => d.BolaBogchadami == true).
                         ToList()[0].BolaId;
                }
            }
            if (checkIsExistPhoneNumber != -1)
            {
                MessageBox.Show("Id:"+checkIsExistPhoneNumber.ToString());
            }
            else
            {
                MessageBox.Show("Ma'lumot topilmadi !!! ");
            }

        }

        private void Idni_unutdingizmi_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("tarbiyachi");
            comboBox1.Items.Add("Haydovchi");
            comboBox1.Items.Add("oshpaz");
            comboBox1.Items.Add("Bola");
        }

        private void HarakatOrtga_Click(object sender, EventArgs e)
        {
            var bbk = new Bolalar_bogchasi_kirish();
            bbk.Show();
            this.Hide();
        }
    }
}
