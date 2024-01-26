using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolalarBogchasi.Override
{
    internal class Hisobot2:Xisobot
    {
        public override void Hisobot()
        {
            MessageBox.Show("Agar ma'lumot qo'shmoqchi bo'lsangiz malumotlar to'liq kiritiladi," +
          "ammo malumotni o'chirmoqchi bo'lsangiz id" +
          "o'zi kifoya");
        }
    }
}
