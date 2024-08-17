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
            #region İki sayıyı bölme durumu 
            try
            {
                int sayi1, sayi2;
                Console.WriteLine("birinci");  
                sayi1=int.Parse(Console.ReadLine());
                Console.WriteLine("birinci");
                sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Bölüm:{sayi1/sayi2}");

            }
            catch (Exception ex)//en sonda olmalıdır
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
            #endregion
        }
    }
}