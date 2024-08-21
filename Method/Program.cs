namespace Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatimi
            /*
             * Metod Nedir : Belirli bir işlevi yerine yetirmek icin kullanilan bir kod blogudur
             * Metodlarin tipleri => geriye deger donen yada donmeyen metodlar 
             *                       Eger metodlar geriye deger donmeyecek ise void olarak isaretlenmek zorundadir.
             *                       Eger DEger Donecek ise tipi belirtmek zorundadir.
             * Butun metodlar parametrik şekilde olabilir.
             * Yani bir meyoda tipini belirtmek şarti ile istediginiz kadar parametre gonderebilirsiniz.
             * 
             * Faydalari : Kodun tekrarini engeller. Tekrar kullanimi saglar
             * Kodun okunakligini arttirir. Programi daha moduler hale getirir.
             * 
             * Tanimlama Sekli 
             * 
             * [Erişim belirteci] [Geri Donus Tipi] [MetodAdi](aldigi parametreler) 
             * {
             *    Kodlar buraya...
             * }
             * 
             * [Erişim belirteci] => metoda kimlerin ulasabilecegini belirler 
             *                       public , private ,internal protected seklinde degerler alabilir.
             *                       public => genel kullanima acik demek. Simdilik bunu kullanacagiz.
             * 
             * [Geri Donus Tipi] => Eger bir sey donmeyecekse void olarak isaretlenmelidir.
             *                      Donus tipi int,float,string,datetime v.b.. degerler donebilir.
             *                      Eger geri donus tipi tanimliyse metod sonunda mutlaka return ifadesi olmak zorundadir.
             *                      
             * (aldigi parametreler) => metoda gondermek istedigimiz verilerdir. Ayrac olarak , ile ayrilirlar
             *                          MEtoda gelecek olan parametrelerin mutlaka tiplerinin de yazilmasi zorunludur.
             *  Metodlarin tanimlandigi yerler genelde  class icerisindedir.                     
             */
            #endregion

            #region Metod imzasi.
            /*
             * Aldgi parametreler farkli oldugu surece ayni isimde metod yazilabilir.
             * Buna metod overload yani aşırı yuklenmesi denir.
             * 
             * Metodun geri donus tipi imzaya dahil degildir.
             * 
             * 
             */

            #endregion
            #region iki Sayiyi toplayacak metod 
            // public static void Topla(int sayi1,int sayi2)
            // public static long Topla(int sayi1,int sayi2)

            #endregion

            #region Metod Cagrimi
            //Topla(3, 5);
            //decimal toplam =Topla(3.5m, 5.3m);
            //Console.WriteLine($"Float Toplam:{toplam.ToString("0.00")}");
            #endregion

            #region Sorular
            /* 1- Kendisine gelen mesaji ekrana yazan metod EkranaYaz()
             * 2- Ekrandan sayi okutup int donen sayioku metodu yaziniz.
             * 3- iki adet integer deger alip bir adet string operator alsin 
             *     Gelen operatore gore 4 islem sonucunu ekrana yazdirsin
             * 
             * 
             * 
             */
            #endregion
            //int sayi = SayiOku("Bir sayi giriniz:");
            //double sayi1 = (double)SayiOku("Double bir sayi giriniz:");
            //double sayi2 = (double)SayiOku("Double bir sayi giriniz:");
            //Console.WriteLine( DortIslem(sayi1, sayi2,'/'));

            // Faktoryel alan metod yaziniz 
            //var faktoryel = Faktoryel(12);
            //Console.WriteLine(faktoryel);
            // Verilen sayini verilen ussunu alacak metod long UssunuAl(2,4)
            long sonuc = Matematik.FaktoryelRecursive(3);
            Console.WriteLine(sonuc);
        }
    }
}

    //    static void Main(string[] args)
    //    {
    //        #region Konu Anlatimi
    //        /*
    //         * Metod Nedir : Belirli bir işlevi yerine yetirmek icin kullanilan bir kod blogudur
    //         * Metodlarin tipleri => geriye deger donen yada donmeyen metodlar 
    //         *                       Eger metodlar geriye deger donmeyecek ise void olarak isaretlenmek zorundadir.
    //         *                       Eger DEger Donecek ise tipi belirtmek zorundadir.
    //         * Butun metodlar parametrik şekilde olabilir.
    //         * Yani bir meyoda tipini belirtmek şarti ile istediginiz kadar parametre gonderebilirsiniz.
    //         * 
    //         * Faydalari : Kodun tekrarini engeller. Tekrar kullanimi saglar
    //         * Kodun okunakligini arttirir. Programi daha moduler hale getirir.
    //         * 
    //         * Tanimlama Sekli 
    //         * 
    //         * [Erişim belirteci] [Geri Donus Tipi] [MetodAdi](aldigi parametreler) 
    //         * {
    //         *    Kodlar buraya...
    //         * }
    //         * 
    //         * [Erişim belirteci] => metoda kimlerin ulasabilecegini belirler 
    //         *                       public , private ,internal protected seklinde degerler alabilir.
    //         *                       public => genel kullanima acik demek. Simdilik bunu kullanacagiz.
    //         * 
    //         * [Geri Donus Tipi] => Eger bir sey donmeyecekse void olarak isaretlenmelidir.
    //         *                      Donus tipi int,float,string,datetime v.b.. degerler donebilir.
    //         *                      Eger geri donus tipi tanimliyse metod sonunda mutlaka return ifadesi olmak zorundadir.
    //         *                      
    //         * (aldigi parametreler) => metoda gondermek istedigimiz verilerdir. Ayrac olarak , ile ayrilirlar
    //         *                          MEtoda gelecek olan parametrelerin mutlaka tiplerinin de yazilmasi zorunludur.
    //         *  Metodlarin tanimlandigi yerler genelde  class icerisindedir.                     
    //         */
    //        #endregion

//        #region Metod imzasi.
//        /*
//         * Aldgi parametreler farkli oldugu surece ayni isimde metod yazilabilir.
//         * Buna metod overload yani aşırı yuklenmesi denir.
//         * 
//         * Metodun geri donus tipi imzaya dahil degildir.
//         * 
//         * 
//         */
//        #endregion

//        #region Metod Cagrimi
//        Topla(3, 5);
//        decimal toplam =Topla(3.5m, 5.3m);
//        Console.WriteLine($"Float Toplam:{toplam.ToString("0.00")}");
//        #endregion

//        #region Sorular
//        /* 1- Kendisine gelen mesaji ekrana yazan metod EkranaYaz()
//         * 2- Ekrandan sayi okutup int donen sayioku metodu yaziniz.
//         * 3- iki adet integer deger alip bir adet string operator alsin 
//         *     Gelen operatore gore 4 islem sonucunu ekrana yazdirsin
//         */
//        #endregion
//        int sayi = SayiOku("Bir sayi giriniz:");
//       double sayi1 = (double)SayiOku("Double bir sayi giriniz:");
//        double sayi2 = (double)SayiOku("Double bir sayi giriniz:");
//        Console.WriteLine( DortIslem(sayi1, sayi2,'/'));

//        // Faktoryel alan metod yaziniz 
//        var faktoryel = Faktoryel(12);
//        Console.WriteLine(faktoryel);
//        // Verilen sayini verilen ussunu alacak metod long UssunuAl(2,4)
//        long sonuc = Matematik.FaktoryelRecursive(3);
//        Console.WriteLine(sonuc);


//    //    //soru3 
//    //    Console.Write("Birinci sayıyı girin: ");
//    //    int sayi1 = int.Parse(Console.ReadLine());
//    //    Console.Write("İkinci sayıyı girin: ");
//    //    int sayi2 = int.Parse(Console.ReadLine());

//    //    Console.Write("Operatörü girin (+, -, *, /): ");
//    //    string operatoru = Console.ReadLine();

//    //    switch (operatoru)
//    //    {
//    //        case "+":
//    //            Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
//    //            break;
//    //        case "-":
//    //            Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
//    //            break;
//    //        case "*":
//    //            Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
//    //            break;
//    //        case "/":
//    //            if (sayi2 != 0)
//    //            {
//    //                Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
//    //            }
//    //            else
//    //            {
//    //                Console.WriteLine("Hata: Bir sayı sıfıra bölünemez");
//    //            }
//    //            break;
//    //        default:
//    //            Console.WriteLine("Geçersiz operatör.");
//    //         break;
//    //    }

//    //} 
//    ////soru1
//    //public static void EkranaYaz(string mesaj)
//    //{
//    //    Console.WriteLine(mesaj);
//    //}

//    ////soru4
//    Console.WriteLine("Lütfen bir plaka kodu gir:");
//        int plakaKodu;

//        while (!int.TryParse(Console.ReadLine(), out plakaKodu))
//        {
//            Console.WriteLine("Geçersiz giriş.");
//        }
//        string sehir = SehirGetir(plakaKodu);
//        Console.WriteLine("Sonuç: " + sehir);

//        //soru7

//        Console.WriteLine("Lütfen bir tam sayı girin:");
//        int sayi;

//        while (!int.TryParse(Console.ReadLine(), out sayi))
//        {
//            Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin:");
//        }

//        BasamaklariYazdir(sayi);
//        //soru 2

//        Console.WriteLine("Lütfen mesafeyi kilometre cinsinden girin:");
//        double mesafe;
//        while (!double.TryParse(Console.ReadLine(), out mesafe) || mesafe <= 0)
//        {
//            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin:");
//        }

//        Console.WriteLine("Lütfen süreyi dakika cinsinden girin:");
//        double sure;
//        while (!double.TryParse(Console.ReadLine(), out sure) || sure <= 0)
//        {
//            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin:");
//        }

//        double hiz = HizHesapla(mesafe, sure);
//        Console.WriteLine($"Bu mesafeyi {sure} dakikada kat etmek için {hiz} km/s hızla gitmeniz gerekmektedir.");


//        //soru3
//        Console.WriteLine("Lütfen dizi eleman sayısını girin:");
//        int elemanSayisi;
//        while (!int.TryParse(Console.ReadLine(), out elemanSayisi) || elemanSayisi <= 0)
//        {
//            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı girin:");
//        }

//        int[] rastgeleDizi = DiziOlustur(elemanSayisi);
//        Console.WriteLine("Oluşturulan dizi:");
//        foreach (int sayi1 in rastgeleDizi)
//        {
//            Console.Write(sayi1 + " ");
//        }

//        //soru5
//        Console.WriteLine("Lütfen bir metin girin:");
//        string metin = Console.ReadLine();

//        SesliHarfSayisi(metin);
//    }

//    static string SehirGetir(int kod)
//    {

//        //soru4 
//        string[] sehirler = {
//        "Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın",
//        "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
//        "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum",
//        "Eskişehir", "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta",
//        "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir",
//        "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla",
//        "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas",
//        "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat",
//        "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
//        "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
//    };


//        if (kod == 0)
//        {
//            Random rnd = new Random();
//            int index = rnd.Next(sehirler.Length);
//            return sehirler[index];
//        }

//        else if (kod > 0 && kod <= sehirler.Length)
//        {
//            return sehirler[kod - 1];
//        }
//        else
//        {
//            return "Geçersiz plaka kodu";
//        }

//    }
//    //SORU7
//    static void BasamaklariYazdir(int sayi)
//    {
//        if (sayi < 0)
//        {
//            sayi = Math.Abs(sayi);
//        }

//        string sayiStr = sayi.ToString();
//        foreach (char basamak in sayiStr)
//        {
//            Console.WriteLine(basamak);
//        }

//    }
//    //soru2
//    static double HizHesapla(double mesafe, double sureDakika)
//    {

//        double sureSaat = sureDakika / 60.0;
//        double hiz = mesafe / sureSaat;

//        return hiz;
//    }
//    //soru3
//    static int[] DiziOlustur(int elemanSayisi)
//    {

//        Random rnd = new Random();
//        int[] dizi = new int[elemanSayisi];

//        for (int i = 0; i < elemanSayisi; i++)
//        {
//            dizi[i] = rnd.Next(1, 101);
//        }
//        return dizi;
//    }
//    //soru5
//    static void SesliHarfSayisi(string metin)
//    {

//        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

//        HashSet<char> bulunanHarfler = new HashSet<char>();
//        int sesliHarfSayisi = 0;


//        metin = metin.ToLower();


//        foreach (char karakter in metin)
//        {
//            if (Array.Exists(sesliHarfler, h => h == karakter))
//            {
//                sesliHarfSayisi++;
//                bulunanHarfler.Add(karakter);
//            }
//        }
//        Console.WriteLine($"Toplam sesli harf sayısı: {sesliHarfSayisi}");
//        Console.Write("Bulunan sesli harfler: ");
//        foreach (char harf in bulunanHarfler)
//        {
//            Console.Write(harf + " ");
//        }
//        Console.WriteLine();
//    }
//    //soru1
//    public static void KdvHesapla(int tutar, int kdv, bool dahilmi)
//    {
//        if (dahilmi)
//        {
//            double kdvtutari = tutar * kdv / 100;
//            Console.WriteLine($"kdv tutarı:{kdvtutari}");
//            Console.WriteLine($"kdv tutarı:{kdvtutari + tutar}");

//        }
//            else
//            {

//            }
//        }
//    }
//} 

//soru1 


/*
             * 1- KdvHesapla(100,20,dahil) => 83.33 
             *    KdvHesapla(100,20,haric) => 120
             * 2- HizHesapla(100km,30 daki) => 200 km hizla gitmen lazim  +  
             * 
             * 
             * 3 -DiziOlustur(elemansayisi) => int tipinden icerisinde 1-100 rastgele sayilarin oldugu bir dizi donecek+
             * 
             * 4- SehirGetir(0)=> rasgtgele bir sehir getirsin.+
             *    SehirGetir(34) => istanbulu getirsin.
             *    
             * 5- Sesliharfsayisi(string ) => 5 adet sesli harf vardir . a,e,i seklinde bir cikti versin+
             * 
             * 6- Sifrele(string) => sifrelenmis sekilde bastirsin. SifreCoz(sifrelenmis) => kelime //sezar algoritması kullanılır
             * 
             * 7- Klavyeden girilen bir tamsayinin basamaklarini ekrana yazdiran metod. BasamakBul(int) +
             * 
             *            */