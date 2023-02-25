﻿using System;

namespace staticclassandmembers

{
    class Program
    {

        static void Main (string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe","Yilmaz","IT");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Hüseyin","Susmaz","IT");
            Calisan calisan2 = new Calisan("Alex","Sara","IT");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            
            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işleminin sonucu: {0}", Islemler.Çikar(400,50));


            // static sınıfın üyelerine sınıf adı . diye erişilir.
        
            //main metodu statictir. bir sınıf içerisindeki static olmayan fieldlara o sınıftan oluşturduğumuz nesne aracılığıyla erişiyoruz.

            //static sınıflarda static olmayan herhangi bir metod ve property kullanılamaz.

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;

        private string Soyisim;

        private string Departman;

        static Calisan()
        
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;

        }

    }

    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Çikar (int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

    }

}
