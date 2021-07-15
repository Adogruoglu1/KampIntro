using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Kurs1","Kurs2","Kurs3","Kurs4"};

            //for yazıp 2 kez tab a bas
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //dizi temelli yapıları dönmeye yarar, kurs yerine ne yazarsan çalışır, diziyi kolay dolaş...
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


           
        }
    }
}
