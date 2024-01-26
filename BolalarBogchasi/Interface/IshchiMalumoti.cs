using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolalarBogchasi.Interface
{
    internal interface IshchiMalumoti
    {
        public string IshningNomi { get; set; }
        public int IshchiId { get; set; }
        public string IshchiIsmi { get; set; }
        public string IshchiFamiliyasi { get; set; }
        public string IshchiKelganKun { get; set; }
        public string IshchiTelRaqami { get; set; }
        public string IshchiElektronPochta { get; set; }
        public int IshchiMaoshi { get; set; }
        public bool IshchiBogchadami { get; set; } 
    }
}
