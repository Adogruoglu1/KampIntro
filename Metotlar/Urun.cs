using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Urun
    {
        //Property=Özellik
        public int Id { get; set; }//Ürünleri birbirinden ayıran tc no
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
    }
}
