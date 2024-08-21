using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Matematik
    {
        public static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine($"Toplam:{sayi1 + sayi2}");
        }

        public static long Topla(long sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Topla(byte sayi1, byte sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Topla(short sayi1, short sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Topla(long sayi1, long sayi2)
        {
            return sayi1 + sayi2;
        }
        public static float Topla(float sayi1, float sayi2)
        {
            return sayi1 + sayi2;
        }
        public static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        /// <summary>
        /// Gelen iki decimal sayiyi toplar ve sonucu geri doner.
        /// </summary>
        /// <param name="sayi1">Decimal tipinden olmalidir </param>
        /// <param name="sayi2">Decimal tipinden olmalidir</param>
        /// <returns>Geriye decimal doner</returns>
        public static decimal Topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }
        public static double UsHesapla(double taban, double us)
        {
            double sonuc = 1;

            Math.Pow(2, 2);
            if (us < 1)
            {
                //taban = 1 / taban;
                //us = -us;
            }

            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }

            return sonuc;
        }

        public static long Faktoryel(int sayi)
        {
            long sonuc = 1;
            for (int i = 1; i < sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        // Recursive metod ile faktoryel

        public static long FaktoryelRecursive(int sayi)
        {

            //if (sayi < 0)
            //{
            //    Console.WriteLine("Negatif sayi girilemez");
            //    return 1;
            //}
            if (sayi >= 2)
            {
                return sayi * FaktoryelRecursive(sayi - 1);
            }
            else
            {
                return 1;
            }
        }
        public static double DortIslem(char islem)
        {
            double sayi1 = (double)Ekran.SayiOku("Double bir sayi giriniz:");
            double sayi2 = (double)Ekran.SayiOku("Double bir sayi giriniz:");
            switch (islem)
            {
                case '+':
                    return sayi1 + sayi2;
                case '-':
                    return sayi1 - sayi2;
                case '/':
                    try
                    {
                        return sayi1 / sayi2;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Sifira bolme hatasi");
                        return 0;
                    }
                case '*':
                    return sayi1 * sayi2;
                default:
                    Console.WriteLine("Beklenmedik bir durum olustu.");
                    return 0;
            }
        }
        public static double DortIslem(double sayi1, double sayi2, char islem)
        {

            double sonuc = 0;
            switch (islem)
            {
                case '+':
                    return sayi1 + sayi2;
                case '-':
                    return sayi1 - sayi2;
                case '/':
                    try
                    {
                        return sayi1 / sayi2;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Sifira bolme hatasi");
                        return 0;
                    }
                case '*':
                    return sayi1 * sayi2;
                default:
                    Console.WriteLine("Beklenmedik bir durum olustu.");
                    return 0;
            }
        }
    }
}
