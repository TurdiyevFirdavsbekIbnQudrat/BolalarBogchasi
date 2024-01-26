using BolalarBogchasi.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolalarBogchasi.Formlar.tolovQilindi
{
    public partial class tolovqilindi : Form
    {
        public tolovqilindi()
        {
            InitializeComponent();
        }
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=BogchaDB;";

        public async Task Update(int pul,string data,int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var commandText = $"UPDATE public.\"Child\"" +
                " SET \"BolaTolovi\"=@BolaTolovi,\"BolaKelganKun\"=@BolaKelganKun" +
                " WHERE \"BolaId\" = @BolaId ";

                var user = new Bolalar()
                {   BolaId=id,
                    BolaTolovi = pul,
                    BolaKelganKun = data,
                };


                await connection.ExecuteAsync(commandText, user);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tolov = Convert.ToInt32(Tolov_miqdori.Text);
            int tolovchiId = Convert.ToInt32(ID_bogchadan_olingan.Text);
            string bugun = "31/12/2024";
            int dataOy = 12;
            int dataKun = 31;
            int dataYil = 2024;
            using(var context = new BogchaDB())
            {
                var ListB = context.Child.Where(c => c.BolaId == tolovchiId).
                        ToList();
                int datakunb = Convert.ToInt32(ListB[0].BolaKelganKun.Split("/")[0]);
                int dataOyb = Convert.ToInt32(ListB[0].BolaKelganKun.Split("/")[1]);
                int datayilb = Convert.ToInt32(ListB[0].BolaKelganKun.Split("/")[2]);
                Amallar.ayir = Ayiruv.ayiruv;
                int OyniHisobi=Amallar.ayir(dataOy, dataOyb);
                int YilniHisobi = Amallar.ayir(dataYil, datayilb)*12;
                OyniHisobi=OyniHisobi+YilniHisobi;
                int Pul =Convert.ToInt32( ListB[0].BolaTolovi);
                int UmumiyPulQiymati = 270000 * OyniHisobi+Pul-tolov;
                Update(UmumiyPulQiymati, bugun, tolovchiId);    
            }

        }

        private void tolovqilindi_Load(object sender, EventArgs e)
        {

        }
    }
}
