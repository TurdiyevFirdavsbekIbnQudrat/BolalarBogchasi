using BolalarBogchasi.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BolalarBogchasi.Malumotlarni_qo_shish
{
    public partial class MalumotQoshish : Form
    {
        public MalumotQoshish()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Bolaning_Manzili_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guruh_Nomi_SelectedIndexChanged(object sender, EventArgs e)
        {

       
        }
        
        private void BolaningBarchaMalumotlari()
        {
        }
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=BogchaDB;";

        private void Bolani_bogchaga_qoshish_Click(object sender, EventArgs e)
        {
    
            using (var connection = new NpgsqlConnection(connectionString))
            {
                int GuruhIdSearch, HaydovchiIdSearch, CoachIdSearch;
                using (var context = new BogchaDB())
                {
                     GuruhIdSearch = context.Group.Where(Name => Name.GuruhNomi == Guruh_Nomi.Text).ToList()[0].GuruhId;
                     HaydovchiIdSearch = context.Taxi.Where(Name => Name.HaydovchiManzili == Bolaning_Manzili.Text).Where(c=>c.IshchiBogchadami==true).ToList()[0].IshchiId;
                     CoachIdSearch = context.Coach.Where(Name => Name.BerilganGuruhNomi == Guruh_Nomi.Text).Where(c => c.IshchiBogchadami == true).ToList()[0].IshchiId;
                }


                var user = new Bolalar()
            {
             
                 BolaId =Convert.ToInt32(ID_Text_box.Text),
                 BolaGuruhi = Guruh_Nomi.Text,
                 BolaningManzili = Bolaning_Manzili.Text,
                 BolaIsmi = Bola_Ismi_Textbox.Text,
                 BolaFamiliyasi = Bola_familiyasini_kiritish_text_box.Text,
                 BolaKelganKun = GuruhAzosiBoldi.Text,
                 BolagaBoglanishTelRaqami = OilaTelRaqami_text_box.Text,
                 BolagaBoglanishElektronPochta = Boglanish_Emaili_text_box.Text,
                 BolaBogchadami = true,
                 BolaTolovi = 270000,
                 GuruhId = GuruhIdSearch,
                 HaydovchiId = HaydovchiIdSearch,
                 TarbiyachiId = CoachIdSearch,
            };
            var sqlQuery = "Insert into public.\"Child\"(\"BolaId\",\"BolaGuruhi\",\"BolaningManzili\",\"BolaIsmi\",\"BolaFamiliyasi\",\"BolaKelganKun\",\"BolagaBoglanishTelRaqami\",\"BolagaBoglanishElektronPochta\",\"BolaBogchadami\",\"BolaTolovi\",\"GuruhId\",\"HaydovchiId\",\"TarbiyachiId\") " +
                "values (@BolaId,@BolaGuruhi,@BolaningManzili,@BolaIsmi,@BolaFamiliyasi,@BolaKelganKun," +
                "@BolagaBoglanishTelRaqami,@BolagaBoglanishElektronPochta,@BolaBogchadami,@BolaTolovi," +
                "@GuruhId,@HaydovchiId,@TarbiyachiId)";
            connection.Execute(sqlQuery, user);

            }

         }
        public async Task Update()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var commandText = "UPDATE public.\"Child\""+
                " SET \"BolaBogchadami\"=@BolaBogchadami"+
                " WHERE \"BolaId\" = @BolaId ";

                var user = new Bolalar()
                {
                    BolaId = Convert.ToInt32(ID_Text_box.Text),
                    BolaBogchadami = false,
                };


                await connection.ExecuteAsync(commandText, user);
            }
        }
        private void Bolani_Chiqarib_yuborish_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void ID_Text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void MalumotQoshish_Load(object sender, EventArgs e)
        {

            foreach (var name in Enum.GetValues(typeof(Manzillar)))
            {
                Bolaning_Manzili.Items.Add(name);
            }
            foreach (var name in Enum.GetNames(typeof(Guruhlar)))
            {
                Guruh_Nomi.Items.Add(name);
            }
        }
        
    }
}
