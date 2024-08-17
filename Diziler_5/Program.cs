namespace Diziler_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Konu Anlatimi 
            /*
             * Birden fazla ayni tipten veriyi bit arada tutmamizi saglayan 
             * nesnelerdir. Dizilerin eleman sayisi sabittir.
             * Sonradan degistirilemezler.
             * 
             * index her zaman 0'dan başlar.
             * 
             * Cok karsilasilan hata : Index was outside the bound of the array
             * Bu hata da dizinin eleman sayisinin disinda bir işlem yapiliyor demektir.
             * 
             * 
             * Tanimlamam Kurali : <veri Tipi>[] diziAdi ;
             *                      int[] sayilar ;
             *                      DateTime[] tarihler;
             *                      bool[] test;
             */

            #endregion

            #region Dizi Tanimlama ve deger atama

            int[] notlar; // Burada dizi tanimlanmis olsada eleman sayisi belli degildir.
            int[] sayilar = new int[10]; // Bu 10 elemanli bir dizidir. Default degerleri 0 dir.
            int[] sayilar2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 10 Elelmanli bir dizidir. Burada ilk deger atamasi yapilmiştir


          //  Tek tek deger atamak icin dizi index' kullanilir
            sayilar2[3] = 20; // Burada 4. Elemana 20 degeri atanmistir.

            /* Dizilerin ekrana bastirilmasi icin bildigimiz dongulerin hepsi gecerlidir.
            * Genelde for dongusu kullanilir. 
            * Ancak sıklıkla foreach de kullanilir
            * foreach dongu degildir. Iterasyondur. 
            * Aradaki fark 1-10 arasindaki sayilari foreach'le ekrana yazdiramayiz.
            * foreach icin mutlaka bir veri seti gereklidir. Bu ister dizi ister liste olabilir.
            */
            //for (int i = 200; i > 100; i--)
            //{

            //}

            #region var keyword'u
            /*
             * var javascript deki var benzeridir.
             * runtime sirasinda veri tipi belli olur. 
             * Veri tipi belli  olduktan sonrasinda artik baska bir veri tipi atilamaz
             */
            var temp = DateTime.Now;
            //temp = "ali veli"; // Burasi hata verecektir.
            #endregion

            // Foreach ile kullanimi 
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }
           // for kullanimi
            for (int i = 0; i < sayilar2.Length; i++)
                {
                    Console.WriteLine(sayilar2[i]);
                }

            #endregion

            #region 20 kisilik bir sinifin notlarini rastgele atama yapalim
            int[] notlar1 = new int[20];
            Random rnd = new Random();

            //// Foreach ile donerken deger atamasi yapilamaz . 
            //// Sık yapilan hatalardandir.
            //foreach (var item in notlar)
            //{
            //    item = rnd.Next(20, 100);
            //}



            for (int i = 0; i < notlar1.Length; i++)
            {
                notlar1[i] = rnd.Next(20, 100);
            }

            foreach (var item in notlar1)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region string 'e farkli bakis

            string str = "Beşiktaş";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            foreach (char ch in str)
            {
                Console.WriteLine(ch);
            }
            #endregion

            #region Cok Boyutlu diziler 
            /*
             * Iki boyutlu bir dizi icin int[,] matris = new int[2,3];
             * 3 Boyutlu bir dizi icin int[,,] kup = new int[3,3,3];
             * 
             * 
             */

            int[,] matris = new int[3, 3];
            Console.WriteLine($"Matrisin 1. Boyutu {matris.GetLength(0)}\nMatrisin 2. Boyutu {matris.GetLength(1)}");

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.Next(100);
                }
            }

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.WriteLine(matris[i, j]);
                }
            }

            #region  20 kisiliik bir sinifin 2 vize bir final notunu tutacak diziyi tanimlayiniz.
            int[,] notlar2 = new int[20, 3];

            for (int i = 0; i < notlar2.GetLength(0); i++)
            {
                for (int j = 0; j < notlar2.GetLength(1); j++)
                {
                    notlar2[i, j] = rnd.Next(20, 50);
                }
            }
            //vizelerin toplaminin % 30 finalin % 70 'i alinacak.
            // 50 ve uzeri geçti olacak
            // Bu dizideki ogrencilerin geçme kalma durumunu ekrana basiniz

            // 0 => 20,40,60 Ortalamasi:
            double ortalama;
            for (int i = 0; i < notlar2.GetLength(0); i++)
            {
                ortalama = notlar2[i, 0] * 0.15 + notlar2[i, 1] * 0.15 + notlar2[i, 2] * 0.7;

                Console.WriteLine($"{i}. Ogrenci Vize1:{notlar2[i, 0]} Vize2:{notlar2[i, 1]} Final:{notlar2[i, 2]}  Ortalama:{ortalama.ToString("0.00")} Sonuc :" + (ortalama >= 50 ? "Gecti" : "Kaldi"));
            }

            #endregion
            #endregion

            #region Dizideki en kucuk ve en buyuk elemani bulma
            int[] sayilar1 = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.WriteLine(sayilar1[i]);
            }
            Console.WriteLine("********************");
            Console.WriteLine(sayilar1.Max());
            Console.WriteLine(sayilar1.Min());

            #endregion

            //#region Olusturdugunuz int[] dizileri siralayin 
            //var sayi = Ekran.SayiOku("Bir sayi giriniz:");
            //#endregion

        }
    }
}