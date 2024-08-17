namespace Donguler_4
{
    public class Program
    {
        static void Main(string[] args) //static olarak tanımlıyoruz
        {
            #region Konu Anlatimi 
            /*
             *  3 adet Dongumuz var .
             *  for,while,do-while 
             *  
             *  foreach dongu degildir. Iterasyondur. Yani foreach calisabilmesi icin 
             *  mutlaka elimizde bir dataset olmasi gerekir.
             *  Yani ya bir dizi olacak yada bir liste v.b.. bir dataset olacak.
             */
            #endregion

          //  #region For Dongusu
          //  /*
          //   * For dongusu icin bir başlangic degeri gerekir. Bir kosul olacak ve artim miktari olacak
          //   * Syntax for(başlangiç;koşul;artim)    
          //   */
          //  int temp = 0;
          //  int sayi = temp++; //Once atama yapip sonra sayiyi 1 arttirir
          //  sayi = ++temp; // Once sayiyi artitir sonra atama yapar.

          // // 1 - 10 arasindaki sayilari bastiralim
          //  for (int i = 0; i < 10; i++)
          //  {
          //      Console.WriteLine(i);
          //  }
          //  // 10-20 arasindaki sayilari bastiralim
          //  for (int i = 10; i <= 20; i++)
          //  {
          //      Console.WriteLine(i);
          //  }
          //  // 50-20 arasindaki sayilari bastiralim
          //  for (int i = 50; i >= 20; i--)
          //  {
          //      Console.WriteLine(i);
          //  }


          //  #endregion
          //  #region Ornek 1 : ilk yuz sayinin toplami ve ortalamasi nedir ?
          //  int toplam = 0;
          //  for (int i = 0; i <= 100; i++)
          //  {
          //      toplam += i;
          //  }
          //  //iki integer sayinin bolumu integer'dir . Kusuratli cikmasi icin degerlerden
          //  // birisinin kesirli bir sayiya cevrilmesi gerekir.
          //  float ortalama = toplam / 100f;
          //  ortalama = (float)toplam / 100;
          //  ortalama = toplam / (float)100;
          //  ortalama = Convert.ToSingle(toplam) / (float)100;



          //  Console.WriteLine(ortalama);
          //  #endregion

          //  #region 2015 ile 2025 arasindaki yillari ekrana basiniz. Ancak PAndemi yilini es geçiniz.
          //  for (int i = 2015; i < 2026; i++)
          //  {
          //      if (i != 2020)
          //          Console.WriteLine(i);
          //  }
          //  //bir sonraakine geç demek continue
          //  for (int i = 2015; i < 2026; i++)
          //  {
          //      if (i == 2020)
          //          continue;
          //      Console.WriteLine(i);
          //  }
          ////  Donguyu Kirmak icin break kullanilir.
          //  for (int i = 2015; i < 2026; i++)
          //  {
          //      if (i == 2020)
          //          break;
          //      Console.WriteLine(i);
          //  }

          //  //Programdan cikmak icin return kullanilir
          //  for (int i = 2015; i < 2026; i++)
          //  {
          //      if (i == 2020)
          //          return;
          //      Console.WriteLine(i);
          //  }

          //  Console.WriteLine("Program Sonu");
          //  #endregion

            #region While Dongusu
            /*
             * while kosul dogru oldugu surece işlemleri gerçekleştiren bir dongudur
             * genel syntax 
             * while(kosul){ Kosul dogru oldugu surece}
             */

            #region 0 girilene kadar ekrandan okutulan sayilari toplayip yazdiralim
            int toplam2 = 0, sayi2 = 1, sayac = 0;
            while (sayi2 != 0)
            {
                Console.Write("Sayi  giriniz:");
                sayi2 = int.Parse(Console.ReadLine());
                toplam2 += sayi2; // toplam = toplam + sayi;
                sayac++; // sayac = sayac +1;
            }
            Console.WriteLine("Girilen Sayilarin adedi " + sayac + " Toplami :" + toplam2);
            Console.WriteLine("Girilen Sayilarin adedi {0} Toplami :{1}", sayac, toplam2);
            Console.WriteLine($"Girilen Sayilarin adedi {sayac} Toplami :{toplam2}");



            #endregion


            #region Sayi Tahmin oyunu : 1-50 arasi sayi tutulacak. Kullaniciya 5 tahmin hakki verilecek
            // Eger tutulandan daha buyuk sayi girilirse daha kucuk bir sayi giriniz mesaji verecek
            // Eger tutulandan daha kucuk sayi girilirse daha buyuk bir sayi giriniz mesaji verecek
            // Oyunu bildiyse eger kacinci denemede bildigini yazdirin.
            // En sonunda oyuna devam etmek istiyormusunuz sorusunu alin. VE ona gore tekrarlatin 


            Random rnd = new Random();
            string devam = "e";
            while (devam != "h")
            {
                Console.Clear();
                int tutulansayi = rnd.Next(1, 50);
                byte tahminHakki = 5;
                int tahminedilen = 0;
                do
                {
                    Console.WriteLine("1-50 arasinda bir sayi giriniz:");
                    tahminedilen = int.Parse(Console.ReadLine());
                    tahminHakki--;
                    if (tahminedilen == tutulansayi)
                    {
                        Console.WriteLine($"Tebrikler Bildiniz.{5 - tahminHakki}. denemede buldunuz ");
                        break;
                    }
                    else if (tahminedilen > tutulansayi)
                    {

                        Console.WriteLine("Daha kucuk bir sayi giriniz. ");
                        Console.WriteLine($"Kalan Hakkiniz:{tahminHakki}");
                    }
                    else
                    {

                        Console.WriteLine("Daha buyuk bir sayi giriniz. ");
                        Console.WriteLine($"Kalan Hakkiniz:{tahminHakki}");

                    }


                } while (tahminHakki > 0);
                Console.WriteLine("Devam etmek istiyormusunuz [e/h]");
                devam = Console.ReadLine().ToLower();
            }


            #endregion

            #region Fibanocci sayilari 1,1,2,3,5,8,13,21,34... kendinen onceki iki sayini toplami şeklindedir.
            // ilk 20 fibanocci sayisini ekrana bastirin.
            int sayi4 = 0, sayi3 = 1, toplam1;

            for (int i = 1; i < 21; i++)
            {
                toplam1 = sayi3 + sayi4;
                Console.Write(toplam1 + " ");
                sayi3 = sayi4;
                sayi4 = toplam1;

            }


            #endregion

            #region ilk 20 asal sayiyi yazdirin 

            int sayac1 = 1, altSayac = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        altSayac++;
                    }
                }

                if (altSayac == 2)
                {
                    Console.WriteLine(i);
                    sayac++;
                }

                altSayac = 0;
                if (sayac1 == 20) break;

            }

            #endregion


            #endregion
        }
    }
}