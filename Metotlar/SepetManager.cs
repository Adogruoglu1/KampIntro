using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //Manager lı ifadeler bir operasyon tutyor demektir, ortak operasyonlar için, örnek sepete ekle işlemi
    class SepetManager
    {
        //naming convention
        // () sonunda görürsen bunun bir metod olduğunu anla
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi."+ urun.Adi);
            //
            //
            //
        }

        public void Ekle2()
        {

        }
    }
}
