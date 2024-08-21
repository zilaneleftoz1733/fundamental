namespace MetodlarLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorular
            /*
             * 1- KdvHesapla(100,20,dahil) => 83.33 
             *    KdvHesapla(100,20,haric) => 120
             * 2- HizHesapla(100km,30 daki) => 200 km hizla gitmen lazim   
             * 
             * 
             * 3 -DiziOlustur(elemansayisi) => int tipinden icerisinde 1-100 rastgele sayilarin oldugu bir dizi donecek
             * 
             * 4- SehirGetir(0)=> rasgtgele bir sehir getirsin.
             *    SehirGetir(34) => istanbulu getirsin.
             *    
             * 5- Sesliharfsayisi(string ) => 5 adet sesli harf vardir . a,e,i seklinde bir cikti versin
             * Odev
             * 6- Sifrele(string) => sifrelenmis sekilde bastirsin. SifreCoz(sifrelenmis) => kelime
             * 
             * 7- Klavyeden girilen bir tamsayinin basamaklarini ekrana yazdiran metod. BasamakBul(int) 
             * 
             *            
             */

            string[] sehirler ={"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};
            #endregion
            sehirler.Where(p => p.Contains("A"));
            // KdvHesapla(100, 20, false);
            // HizHesapla(60, 30);

            //var dizi = DiziOlustur(10);
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}


            // SehirBul(sehirler,0);
            SesliHarfSayisi("bugun gunlerden persembe");
            Topla('+', 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 33);
        }

        public static void Topla(char islem, params int[] sayilar)
        {
            int toplam = 0;
            if (islem == '+')
            {
                for (int i = 0; i < sayilar.Length; i++)
                {
                    toplam += sayilar[i];
                }
            }
        }
        public static void Topla(int sayi1, int sayi2)
        {

        }
        public static void Topla(int sayi1, int sayi2, int sayi3)
        {

        }
        public static void Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {

        }
        public static void SesliHarfSayisi(string cumle)
        {
            // cumle="bugun gunlerden persembe";
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int sayac = 0;
            foreach (var harf in cumle)
            {
                for (int i = 0; i < sesliHarfler.Length; i++)
                {
                    if (harf == sesliHarfler[i]) sayac++;
                }
            }
            Console.WriteLine(cumle);
            Console.WriteLine("Bulunan sesli harf sayisi :" + sayac);

        }
        public static void SehirBul(string[] sehirler, byte kod)
        {
            Random rnd = new();
            if (kod == 0)
            {
                Console.WriteLine(sehirler[rnd.Next(1, sehirler.Length)]);

            }
            else
            {
                Console.WriteLine(sehirler[kod - 1]);
            }
        }


        public static int[] DiziOlustur(int elemansayisi)
        {
            int[] dizi = new int[elemansayisi];
            Random rnd = new();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 100);
            }
            return dizi;
        }
        public static void KdvHesapla(double tutar, double kdv, bool dahilmi)
        {
            if (dahilmi)
            {
                double kdvtutari = tutar * kdv / 100;
                Console.WriteLine($"Kdv Tutari:{kdvtutari}");
                Console.WriteLine($"Toplam Tutar:{tutar + kdvtutari}");
            }
            else
            {
                double kdvharictutar = tutar / ((100 + kdv) / 100);
                Console.WriteLine("Fiyat:" + tutar);
                Console.WriteLine($"Kdv Haric Tutai:{kdvharictutar}");
                Console.WriteLine($"Kdv Tutar:{tutar - kdvharictutar}");

            }
        }

        public static void HizHesapla(int menzil, int dakika)
        {
            Console.WriteLine($"{menzil} km yolu {dakika} dakikada alabilmek icin {menzil * (60 / dakika)} km hizla gitmeniz gerekir");
        }
    }
    
}