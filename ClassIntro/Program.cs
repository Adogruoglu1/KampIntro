﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            
            //dizi oluşumu
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " :"+ kurs.Egitmen);
            }


        }
    }

    //CLASSLARDA İÇİNDE BİRDEN FAZLA özelliği(prop)olan,yani birden çok özelliği olan bir varlığı topluca ele almamızı sağlar.
    class Kurs
    {
        //prop yaz 2 kez tab a bas
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
