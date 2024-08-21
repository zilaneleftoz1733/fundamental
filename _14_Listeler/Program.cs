using System.Collections;

namespace _14_Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatimi
            /*
             * Listeler ArrayList'lerin tipi belli olan generic halidir.
             * ArrayList gibi dinamik olarak artan bir yapisi vardir.
             * Dizilerdeki gibi baştan eleman sayisini belirtmeye gerek yoktur.
             * ArrayList'lerdeki gibi de object almadigindan tipi belli olacak sekilde calisir.
             * 
             * 
             * 
             */
            #endregion

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(DateTime.Now);

            // Liste Tanilama ORnekleri
            List<string> sehirler = new List<string>() { "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "Hatay", "İzmir" };
            List<DateTime> dateList = new List<DateTime>();
            List<int> sayilar = new List<int>();

            // Liste ye eleman ekleme Add metodu ile yapilir
            sayilar.Add(1);
            sayilar.Add(11);
            sayilar.Add(12);
            sayilar.Add(13);
            sayilar.Add(14);
            sayilar.Add(15);

            dateList.Add(DateTime.Now);
            dateList.Add(DateTime.Now.AddYears(-10));
            dateList.Add(DateTime.Now.AddYears(-20));
            dateList.Add(DateTime.Now.AddYears(-30));

            // Listeden eleman cikarma Remove metodu ile yapilir.
            // Buldugu ilk elemani cikartir.
            sayilar.Remove(1);

            #region En Cok kullanilan metodlari
            // Contains 
            sehirler.Contains("Hatay"); // Listedeki lndex numarasini vermez.
                                        // Sadece listede varmi yokmu ona bakar

            Console.WriteLine(sehirler.IndexOf("Hatay")); // Listedeki buldugu ilk index'i verir
            Console.WriteLine(sehirler.LastIndexOf("Hatay"));// Listedeki buldugu sondan ilk index'i verir


            // ForEach => Lambda Expression uygulanir. 

            sehirler.ForEach(s => Console.WriteLine(s));

            // Max , Min ,Avg ,Sum Metodlari 
            #region Sayilar Listelerde Min Max 
            //Console.WriteLine("Max:" + sayilar.Max());
            //Console.WriteLine("Min:" + sayilar.Min());
            //Console.WriteLine("Avg:" + sayilar.Average()); 
            #endregion

            #region String Listelerde Min Max

            Console.WriteLine("Max:" + sehirler.Max());
            Console.WriteLine("Min:" + sehirler.Min());
            //Console.WriteLine("Avg:" + sehirler.Average());

            #endregion

            #region DateTime Listelerde Min Max
            Console.WriteLine("Max:" + dateList.Max());
            Console.WriteLine("Min:" + dateList.Min());

            #endregion

            #region Siralama Metodlari
            sayilar.Sort(); // Ascanding Siralayacak
            sayilar.ForEach(s => Console.WriteLine(s));
            Console.WriteLine("*********************");
            sayilar.Reverse(); // Descending Siralayacak
            sayilar.ForEach(s => Console.WriteLine(s));
            #endregion
            #endregion
            Random rnd = new Random();
            for (int i = 0; i < sayilar.Count; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
