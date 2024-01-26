
using Microsoft.VisualBasic.ApplicationServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BolalarBogchasi.Boshqaruvchi
{
    public partial class Boshqaruvvchi : Form
    {


        public Boshqaruvvchi()
        {
            InitializeComponent();
        }



        private void IshlarRoyxati_SelectedIndexChanged(object sender, EventArgs e)
        {
        }




        private void GuruhYokiManzil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=BogchaDB;";

        private void Hodimni_bogchaga_qoshish_Click(object sender, EventArgs e)
        {

            using (var connect = new NpgsqlConnection(connectionString))
            {

                if (IshlarRoyxati.Text == "tarbiyachi")
                {
                    using (var connection = new BogchaDB())
                    {
                        int IshJoyiId = connection.Works.
                                 Where(c => c.Name == IshlarRoyxati.Text).
                                 ToList()[0].Id;

                        var User = new Tarbiyachi()
                        {
                            IshchiId = Convert.ToInt32(Hodim_ID_Text_box.Text),
                            IshchiBogchadami = true,
                            IshchiElektronPochta = Hodim_Boglanish_Emaili_text_box.Text,
                            IshchiFamiliyasi = Hodim_familiyasini_kiritish_text_box.Text,
                            IshchiIsmi = Hodim_Ismi_Textbox.Text,
                            IshchiMaoshi = Convert.ToInt32(IshchiMaoshiTextBox.Text),
                            IshningNomi = IshlarRoyxati.Text,
                            IshchiTelRaqami = HodimTelRaqami_text_box.Text,
                            IshchiKelganKun = Hodim_GuruhAzosiBoldi.Text,
                            BerilganGuruhNomi = GuruhYokiManzil.Text,
                            IshId = IshJoyiId,
                        };

                        var sqlQuery = "Insert into public.\"Coach\"(\"IshchiId\",\"BerilganGuruhNomi\",\"IshningNomi\",\"IshchiIsmi\",\"IshchiFamiliyasi\"," +
                            "\"IshchiKelganKun\",\"IshchiTelRaqami\",\"IshchiElektronPochta\",\"IshchiMaoshi\",\"IshchiBogchadami\",\"IshId\") " +
                       "values (@IshchiId,@BerilganGuruhNomi,@IshningNomi,@IshchiIsmi,@IshchiFamiliyasi,@IshchiKelganKun," +
                       "@IshchiTelRaqami,@IshchiElektronPochta,@IshchiMaoshi,@IshchiBogchadami," +
                       "@IshId)";
                        connect.Execute(sqlQuery, User);
                    }
                }
                if (IshlarRoyxati.Text == IshEnums.oshpaz.ToString())
                {
                    using (var connection = new BogchaDB())
                    {
                        int IshJoyiId = connection.Works.
                              Where(c => c.Name == IshlarRoyxati.Text).
                              ToList()[0].Id;
                        var User = new oshpaz()
                        {
                            IshchiId = Convert.ToInt32(Hodim_ID_Text_box.Text),
                            IshchiBogchadami = true,
                            IshchiElektronPochta = Hodim_Boglanish_Emaili_text_box.Text,
                            IshchiFamiliyasi = Hodim_familiyasini_kiritish_text_box.Text,
                            IshchiIsmi = Hodim_Ismi_Textbox.Text,
                            IshchiMaoshi = Convert.ToInt32(IshchiMaoshiTextBox.Text),
                            IshningNomi = IshlarRoyxati.Text,
                            IshchiTelRaqami = HodimTelRaqami_text_box.Text,
                            IshchiKelganKun = Hodim_GuruhAzosiBoldi.Text,
                            IshId = IshJoyiId,
                        };

                        var sqlQuery = "Insert into public.\"Cook\"(\"IshchiId\",\"IshningNomi\",\"IshchiIsmi\",\"IshchiFamiliyasi\"," +
                            "\"IshchiKelganKun\",\"IshchiTelRaqami\",\"IshchiElektronPochta\",\"IshchiMaoshi\",\"IshchiBogchadami\",\"IshId\") " +
                       "values (@IshchiId,@IshningNomi,@IshchiIsmi,@IshchiFamiliyasi,@IshchiKelganKun," +
                       "@IshchiTelRaqami,@IshchiElektronPochta,@IshchiMaoshi,@IshchiBogchadami," +
                       "@IshId)";
                        connect.Execute(sqlQuery, User);

                    }
                }
                if (IshlarRoyxati.Text == IshEnums.haydovchi.ToString())
                {
                    using (var connection = new BogchaDB())
                    {
                        int IshJoyiId = connection.Works.
                              Where(c => c.Name == IshlarRoyxati.Text).
                              ToList()[0].Id;
                        var User = new Haydovchi()
                        {
                            IshchiId = Convert.ToInt32(Hodim_ID_Text_box.Text),
                            IshchiBogchadami = true,
                            IshchiElektronPochta = Hodim_Boglanish_Emaili_text_box.Text,
                            IshchiFamiliyasi = Hodim_familiyasini_kiritish_text_box.Text,
                            IshchiIsmi = Hodim_Ismi_Textbox.Text,
                            IshchiMaoshi = Convert.ToInt32(IshchiMaoshiTextBox.Text),
                            IshningNomi = IshlarRoyxati.Text,
                            IshchiTelRaqami = HodimTelRaqami_text_box.Text,
                            IshchiKelganKun = Hodim_GuruhAzosiBoldi.Text,
                            IshId = IshJoyiId,
                            HaydovchiManzili = GuruhYokiManzil.Text,
                        };

                        var sqlQuery = "Insert into public.\"Taxi\"(\"IshchiId\",\"IshningNomi\",\"HaydovchiManzili\",\"IshchiIsmi\",\"IshchiFamiliyasi\"," +
                            "\"IshchiKelganKun\",\"IshchiTelRaqami\",\"IshchiElektronPochta\",\"IshchiMaoshi\",\"IshchiBogchadami\",\"IshId\") " +
                       "values (@IshchiId,@IshningNomi,@HaydovchiManzili,@IshchiIsmi,@IshchiFamiliyasi,@IshchiKelganKun," +
                       "@IshchiTelRaqami,@IshchiElektronPochta,@IshchiMaoshi,@IshchiBogchadami," +
                       "@IshId)";
                        connect.Execute(sqlQuery, User);

                    }
                }
            }
        }

        private void Boshqaruvchi_Load(object sender, EventArgs e)
        {
            IshlarRoyxati.Items.Add(IshEnums.haydovchi);
            IshlarRoyxati.Items.Add(IshEnums.oshpaz);
            IshlarRoyxati.Items.Add(IshEnums.tarbiyachi);

        }

        int sanoq1 = 0, sanoq2 = 0;
        private void Hodim_ID_Text_box_TextChanged(object sender, EventArgs e)
        {
            if (IshlarRoyxati.Text.Equals(IshEnums.tarbiyachi.ToString()))
            {

                Guruh_yoki_manzil_nomi.Text = "Guruh Nomi";
                if (sanoq1 < 1)
                {
                    foreach (var name in Enum.GetNames(typeof(Guruhlar)))
                    {
                        GuruhYokiManzil.Items.Add(name);
                    }
                }
                sanoq1++;
                Guruh_yoki_manzil_nomi.Show();
                GuruhYokiManzil.Show();



            }
            else
          if (IshlarRoyxati.Text.Equals(IshEnums.haydovchi.ToString()))
            {
                Guruh_yoki_manzil_nomi.Text = "Boriladigan Manzil";
                if (sanoq2 < 1)
                {
                    foreach (var name in Enum.GetNames(typeof(Manzillar)))
                    {
                        GuruhYokiManzil.Items.Add(name);
                    }
                }
                sanoq2++;
                Guruh_yoki_manzil_nomi.Show();
                GuruhYokiManzil.Show();

            }
            else
            {
                Guruh_yoki_manzil_nomi.Hide();
                GuruhYokiManzil.Hide();
            }

        }
        public async Task Update(string s)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var commandText = $"UPDATE public.\"{s}\"" +
                " SET IshchiBogchadami=@Ishdami" +
                " WHERE \"IshchiId\" = @IDIShchi ";

                var user = new UpdateHodim()
                {
                    IDIShchi = Convert.ToInt32(Hodim_ID_Text_box.Text),
                    Ishdami = false,
                };


                await connection.ExecuteAsync(commandText, user);
            }
        }

        private void Hodimni_Chiqarib_yuborish_Click(object sender, EventArgs e)
        {
            if (IshlarRoyxati.Text == "tarbiyachi")
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    var commandText = $"UPDATE public.\"Coach\"" +
                    " SET \"IshchiBogchadami\"=@IshchiBogchadami" +
                    " WHERE \"IshchiId\" = @IshchiId ";

                    var user = new Tarbiyachi()
                    {
                        IshchiId = Convert.ToInt32(Hodim_ID_Text_box.Text),
                        IshchiBogchadami = false,
                    };


                    connection.Execute(commandText, user);
                }

            }
            else
            if (IshlarRoyxati.Text == "haydovchi")
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    var commandText = $"UPDATE public.\"Taxi\"" +
                    " SET \"IshchiBogchadami\"=@IshchiBogchadami" +
                    " WHERE \"IshchiId\" = @IshchiId ";

                    var user = new Haydovchi()
                    {
                        IshchiId = Convert.ToInt32(Hodim_ID_Text_box.Text),
                        IshchiBogchadami = false,
                    };


                    connection.Execute(commandText, user);
                }
            }
            else
            if (IshlarRoyxati.Text == "oshpaz")
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    var commandText = $"UPDATE public.\"Cook\"" +
                    " SET \"IshchiBogchadami\"=@IshchiBogchadami" +
                    " WHERE \"IshchiId\" = @IshchiId ";

                    var user = new oshpaz()
                    {
                        IshchiId = Convert.ToInt32(Hodim_ID_Text_box.Text),
                        IshchiBogchadami = false,
                    };


                    connection.Execute(commandText, user);
                }
            }



        }
    }
}
