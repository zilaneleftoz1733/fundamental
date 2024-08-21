namespace TryCatch_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Konu anlatımı
            /*
             * try catch hata yakalamakta kullanılır.
             * hatalar 3 ana başlıkta toplanır
             * 1-syntax hataları(genelde ide yakalar
             * 2-runtime sırasında çıkan hatalar(sıfıra bölme hatası,tip dönüşüm hataları,ınput output hataları
             * 3-mantık hataları-programcı tarafından yapılan hatlardır.bulunması ve çözülmesi zordur.
             * debug yaparak çözümlenir
             * try{
             * çalıştırılacak kodlar burda
             * }
             * catch{
             * hata yakalandıktan sonra yapılacak işlemler
             * }
             * finally{
             * hata olsun olmasın mutlaka buraya ugrayacak zorunlu değil.}
             * 
             */
            #endregion
            #region İki sayıyı bölme durumu 
            //try
            //{
            //    int sayi1, sayi2;
            //    Console.WriteLine("birinci sayıyı giriniz ");  
            //    sayi1=int.Parse(Console.ReadLine());
            //    Console.WriteLine("ikinci sayiyi giriniz");
            //    sayi2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Bölüm:{sayi1/sayi2}");

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("sıfıra bölme hatası");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("düzgün formatta sayı girme  hatası");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("taşma hatası çok buyuk sayı girdiniz");
            //}
            //catch (Exception ex)//en sonda olmalıdır
            //{
            //    Console.WriteLine("bilinmeyen hata oldu");
            //}

            #endregion
            #region Kontrollu sayi cevrilmesi
            int sayi1, sayi2;
            bool sonuc1, sonuc2;
            float fsayi;
            double dsayi;
            DateTime trh;
            Console.WriteLine("birinci sayıyı giriniz ");
            sonuc1 = int.TryParse(Console.ReadLine(),out sayi1);
            Console.WriteLine("ikinci sayiyi giriniz");
            sonuc2 = int.TryParse(Console.ReadLine(), out sayi2);
            if(sonuc1==true && sonuc2 == true)
            {
                Console.WriteLine("toplam:" +(sayi1 + sayi2));
            }
            sonuc1 = float.TryParse(Console.ReadLine(), out fsayi);
            Console.WriteLine("float :" + fsayi.ToString("0.00"));

            sonuc1 = double.TryParse(Console.ReadLine(), out dsayi);
            Console.WriteLine("decimal :" + dsayi.ToString("0.00"));

            sonuc1 = DateTime.TryParse("01.01.200", out trh);
            Console.WriteLine("tarih :" + trh);


            #endregion
        }
    }
}