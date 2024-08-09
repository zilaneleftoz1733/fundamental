﻿using System;

namespace IFElse
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
         #region  Su sıcaklığını kontrol eden kod
            Console.Write("Su sıcaklığını girin (Celsius): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double sicaklik))
            {
                if (sicaklik <= 0)
                {
                    Console.WriteLine("Su katı halde (buz).");
                }
                else if (sicaklik > 0 && sicaklik < 100)
                {
                    Console.WriteLine("Su sıvı halde.");
                }
                else
                {
                    Console.WriteLine("Su gaz halde (buhar).");
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sıcaklık değeri girin.");
            }

           #region  Haftanın günlerini yazdıran kod
            Console.Write("Gün numarasini girin (1-7): ");
            string gunInput = Console.ReadLine();

            if (int.TryParse(gunInput, out int gun))
            {
                if (gun == 1)
                {
                    Console.WriteLine("Pazartesi");
                }
                else if (gun == 2)
                {
                    Console.WriteLine("Salı");
                }
                else if (gun == 3)
                {
                    Console.WriteLine("Çarşamba");
                }
                else if (gun == 4)
                {
                    Console.WriteLine("Perşembe");
                }
                else if (gun == 5)
                {
                    Console.WriteLine("Cuma");
                }
                else if (gun == 6)
                {
                    Console.WriteLine("Cumartesi");
                }
                else if (gun == 7)
                {
                    Console.WriteLine("Pazar");
                }
                else
                {
                    Console.WriteLine("Geçersiz gün numarası");
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir gün numarası girin.");
            }

            //final no bulma 2 vize 1 final alınacak vizenın yuzde 30u fnalın yude 70 ı aınacak 0 29 arasında ise dd 30 ile 49 arasnda ise cc50 ile 60 arsında bb 70 ile 100 arasında aa olsun 
           
            // int vize1, vize2, final;
            
            // Console.WriteLine("Birinci vize notunu girin: ");
            // vize1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("İkinci vize notunu girin: ");
            // vize2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Final notunu girin: ");
            // final = int.Parse(Console.ReadLine());

            
            // double ortalama = ((vize1+vize2)/2*0.30) + (final * 0.70);

            
            // string harfNotu;
            // if (ortalama >= 0 && ortalama <= 29)
            // {
            //     harfNotu = "DD";
            // }
            // else if (ortalama >= 30 && ortalama <= 49)
            // {
            //     harfNotu = "CC";
            // }
            // else if (ortalama >= 50 && ortalama <= 69)
            // {
            //     harfNotu = "BB";
            // }
            // else if (ortalama >= 70 && ortalama <= 100)
            // {
            //     harfNotu = "AA";
            // }
            // else
            // {
            //     harfNotu = "Geçersiz not";
            // }
            // Console.WriteLine($"Ortalama: {ortalama:F2}, Harf Notu: {harfNotu}");

           #region ürün sorusu
             Console.Write("Ürün adını girin: ");
            string urun = Console.ReadLine();
            if (urun == "domates" || urun == "biber" || urun == "patlıcan")
            {
                Console.WriteLine("Bu ürün sebzeler reyonundadır.");
            }
            else if (urun == "diş macunu" || urun == "parfüm" || urun == "krem")
            {
                Console.WriteLine("Bu ürün kozmetik ürünler reyonundadır.");
            }
            else if (urun == "telefon" || urun == "bilgisayar" || urun == "ses sistemi")
            {
                Console.WriteLine("Bu ürün teknoloji reyonundadır.");
            }
            else
            {
                Console.WriteLine("Bu ürün yok");
            }
                            
             /*Urun fiyati:5 Tl olsun
            Disaridan girilecek siparis sayisina gore
            20 de az ise toplam ucretten % 5 indirim yapilacak
            20 - 50 arasinda ise % 10 indirim
            50 - 100 arasinda ise % 15 indirim
            100 ve uzeri icin % 20 indirim yapilsin
            Ekrana Toplam tutar ,indirim miktari ve Odenecek tutar bilgilerini yazdirin*/
 

           #region fiyat tespiti
            double urunFiyati = 5.0;

            Console.Write("Sipariş sayısını girin: ");
            if (double.TryParse(Console.ReadLine(), out double siparisSayisi) && siparisSayisi > 0)
            {
            
                double indirimOrani;
                if (siparisSayisi < 20)
                {
                    indirimOrani = 0.05;
                    Console.WriteLine("İndirim Oranı: %5");
                }
                else if (siparisSayisi >= 20 && siparisSayisi < 50)
                {
                    indirimOrani = 0.10;
                    Console.WriteLine("İndirim Oranı: %10");
                }
                else if (siparisSayisi >= 50 && siparisSayisi < 100)
                {
                    indirimOrani = 0.15;
                    Console.WriteLine("İndirim Oranı: %15");
                }
                else
                {
                    indirimOrani = 0.20;
                    Console.WriteLine("İndirim Oranı: %20");
                }

                
                double toplamTutar = siparisSayisi * urunFiyati;

                
                double indirimMiktari = toplamTutar * indirimOrani;
                double odenecekTutar = toplamTutar - indirimMiktari;

              
                Console.WriteLine($"Toplam Tutar: {toplamTutar:F2} TL");
                Console.WriteLine($"İndirim Miktarı: {indirimMiktari:F2} TL");
                Console.WriteLine($"Ödenecek Tutar: {odenecekTutar:F2} TL");
            }
            else
            {
                Console.WriteLine("Geçerli bir sipariş sayısı girin.");
            }

       #region sayı bulma  
            // int sayi1 = 5;
            // int sayi2 = 5;

            // if(sayi1 == 5) 
            // {
            //     System.Console.WriteLine("Sayi 5 dir");
            // }
            // else
            // {
            //     System.Console.WriteLine("Sayi 5 degildir");
            // }

            // if(sayi1>sayi2)
            // {

            //   System.Console.WriteLine(sayi1 +" > " +sayi2);  
            // }
            // else if(sayi1==sayi2)
            // {
            //     System.Console.WriteLine(sayi1 +" = " +sayi2);
            // }
            // else
            // {
            //     System.Console.WriteLine(sayi1 +" < " +sayi2);
            // }
            // Console.WriteLine("Hello, World!");
           
        }
    }
}