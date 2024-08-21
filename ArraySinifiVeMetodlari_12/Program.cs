namespace ArraySinifiVeMetodlari_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatimi
            /*
             * Array sinifi Microsoft tarafindan yazilmis dizlerle islem 
             * yapmamizi kolyalastiran bir siniftir.
             * 
             * 
             */
            #endregion



            int[] sayilar = { 11, 21, 13, 41, 15, 61, 17 };
            string[] sehirler ={"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};
            string[] yenisehirler = { "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Sinop", "Trabzon  ", "Tunceli" };

            #region siralama
            //Array.Sort(sayilar);
            //foreach (var item in sayilar)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Clear 
            //Array.Clear(sayilar, 0, 2);
            //foreach (var item in sayilar)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Copy Bir dizden baska bir diziye kopyalama yapar.
            //Array.Copy(sehirler, yenisehirler, 4);
            //foreach (string s in yenisehirler)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion
            #region Resize => Dizinin Eleman sayisini degistirir
            //Array.Resize(ref sayilar, 20);
            #endregion
            #region Fill => Doldurma

            // Array.Fill(yenisehirler, "Batum");
            //foreach (var item in yenisehirler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Reverse => Diziyi tersine cevirir
            //Array.Reverse(yenisehirler);
            //foreach (var item in yenisehirler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region IndexOf => Dizide aradigimiz elemanin indisini verir.
            /*
             * Eger aradigi degeri bulamaz ise -1 doner.
             * Eger aradigi degeri birden fazla bulursa ilk buldugu indis'i verir.
             */

            //int index = Array.IndexOf(yenisehirler, "Sinop");
            //Console.WriteLine(index);
            #endregion


            #region LastIndexOf
            int index = Array.LastIndexOf(yenisehirler, "Sinop");
            Console.WriteLine(index);
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}