using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};//ürünler dizisi


            //in urunler= urunler dizisinin her elemanını tek tek gez
            //urun=o anki elemanın takma ismi
            //Urun=veri tipi=type safe tekniği, var da yazsan olur
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+ " "+ urun.Fiyati+ " "+ urun.Aciklama);
                Console.WriteLine("..........................");
            }
            //cw yaz 2 kez tab a bas
            Console.WriteLine(".........................Metodlar..................");

            //instance örnek
            //Bu kodu istediğim sayfada yazarak çok sayıda sayfada bu metodu kullanabilirim.
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
//Metodlar tekrar tekrar kullanıma yarar. DO NOT REPEAT YOURSELF!, Clean code, Best Practice