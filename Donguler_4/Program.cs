namespace Donguler_4
{
    public class Program
    {
        public static void Main(string[] args) // Main metodunu static olarak tanımladık
        {
            #region Konu Anlatımı
            /* 
             *  3 adet döngümüz var 
             *  for, while, do while
             *  foreach döngüsü değildir, iterasyondur; yani çalıştırılması için bir veri kümesine ihtiyaç duyar; bir liste, dizi veya veri kümesi olmalıdır
             */
            #endregion

            //#region For Döngüsü
            ///* 
            // * for döngüsü için bir başlangıç değeri gerekir, bir koşul ve artırım gerekir.
            // * syntax: for (başlangıç; koşul; artım) {}
            // */
            //int temp = 0;
            //int sayi = temp++;//once atama yapıp sonra sayıyı 1 artırıyor
            //sayi = ++temp;//once sayıyı artırır sonra atama yapar
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //#endregion
            //#region örnek1: ilk yuz sayının toplamı ve ortalamsını yazdır 
            //int toplam = 0;  


            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam += i;  
            //}
            //double ortalama = (double)toplam / 100;
            //Console.WriteLine(" sayının toplamı: {1}", 100, toplam);
            //Console.WriteLine(" sayının ortalaması: {1}", "100", ortalama);
            //#endregion

            //#region 2015 ile 2025 yıllaı arasındaki yilları ekrana yazdır pandemi yılını yazdırma
            //for(int i = 2015;i < 2026; i++)
            //{
            //    if (i == 2020)
            //        continue;
            //    Console.WriteLine(i);
            //}
            ////döngüyü kırmak için break kullanacağız
            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i == 2020)
            //        break;
            //    Console.WriteLine(i);
            //}
            ////programdan çıkmak için return kullanılır.
            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i == 2020)
            //        return;
            //    Console.WriteLine(i);
            //}
            //#endregion

            #region While Dongusu
            /*
             * while kosul doğru olduğu surece işlemleri gerçekleştiren bir döngudur.
             * genel syntax
             * while (koşul)
             * {
             * kodul dogru olduğu surece
             * }
             */
            #region 0 girilene kadar ekrandan okutulan sayıları toplamı
            int toplam = 0, sayi = 1, sayac = 0; 

            while (sayi!=0)
            {
                Console.WriteLine("sayı gir");
                sayi =int.Parse(Console.ReadLine());
                toplam += sayi;
                sayac++;

                Console.Write("girirlen sayıların adedi"+ sayac + "toplamı" + toplam);
                Console.WriteLine("girilen sayıların adedi {0} Toplamı :{1}",sayac,toplam);
                Console.WriteLine($"girilen sayıların adedi{sayac} toplamı :{toplam}");
            }
            #endregion

            #region sayi tahmin oyunu: 1-50 arası sayı tutulacak kullanıcya 5 tahmın hakkı verilecek
            Random rdn = new Random();
            int tutulansayi=rdn.Next(1,50);
            byte tahmin = 5;
            #endregion
            #endregion
        }
    }
}