using System.Reflection.Metadata;

namespace HazirMetodlar_15
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangic = DateTime.Now;
            #region string hazır metotları
            string cumle = "Sanat, insanoğlunun yarattığı en yüce değerdir. Çünkü bir sentezdir. Bütün çağların, bütün çağlardaki insanların akıllarının yaratışıdır. Bundan dolayı etki gücü çoktur. Toplumları bir arada tutan güç olması bundandır.";

            Console.WriteLine($"cumlenin uzunlugu:{cumle.Length}");
            Console.WriteLine($"insanların kelimesi{cumle.IndexOf("insanların")}");
            Console.WriteLine($"cumlemde toplam{cumle.Split(' ').Count()}");
            var cumleler=cumle.Split( '.' );

            foreach( var item  in cumleler )
            {
                Console.WriteLine( item );
            }
            #endregion
            
            #region Replace
            //cumlede yüce yerine değerli yazmak istersek
            //replace metodu cumleyi değiştirmez değişmiş olan cumleyi size verir
            var yeniCumle=cumle.Replace("yüce", "değerli");
            Console.WriteLine( yeniCumle );
            #endregion


            #region Substring=>cumle içinde nokta atışı yaparak istediğimiz
            string str = "bugun gunlerden cuma";
            Console.WriteLine( str.Substring(6));
            Console.WriteLine( str.Substring(6,9));
            string krediKartNo = "1234 5678 9123 4567"; //krediKartNo son dort hanesi
            Console.WriteLine(krediKartNo.Substring(krediKartNo.Length-4));
            string annekizlikSoyadi = "Yilmaz"; // 3. 5 harfi
            Console.WriteLine($"{annekizlikSoyadi[2]} ,{annekizlikSoyadi[4]} ");
            #endregion
            #region ToLower().ToUpper
            string str1 = "bugun gunlerden cuma";
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.ToUpper());
            #endregion
            #region Insert ,remove
            Console.WriteLine(str.Insert(str.Length,"hava cok sıcak"));
            Console.WriteLine(str.Remove(6));
            Console.WriteLine(str.Remove(6,10));
            #endregion
            #region IsNullOrEmpty
            string.IsNullOrEmpty(str);
            #endregion
            #region Sansur
            Console.WriteLine(Sansur( cumle));
            #endregion
            #region Matematik Hazir Metodları
            //üs alma
            Console.WriteLine(Math.Pow(2,3));//8
            //karekok alma
            Console.WriteLine(Math.Sqrt(16));//4

            //kupkok alma
            Console.WriteLine(Math.Pow(8, 1 / 3.0));//2
            //PI
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Tau);

            #endregion
            #region yuvarlama metotları
            //ceiling => verilen ondalıklı sayıyı bir üste yuvarlama
            Console.WriteLine("Ceiling:" + Math.Ceiling(10.1));
            //ceiling => verilen ondalıklı sayıyı bir asagı yuvarlama
            Console.WriteLine("Floor:" + Math.Floor(10.9));
            //round => verilen ondalıklı sayıyı yarısından fazla ise yukaru değilse asağı yuvarlar
            Console.WriteLine("ROUND :" +Math.Round(10.4));
            Console.WriteLine("ROUND :" +Math.Round(10.7));
            Console.WriteLine("ROUND :" + Math.Round(10.5));
            Console.WriteLine("ROUND :" +Math.Round(11.5));
            Console.WriteLine("ROUND :" +Math.Round(12.5));
            Console.WriteLine("ROUND :" +Math.Round(13.5));
            Console.WriteLine("ROUND :" +Math.Round(14.5));

            #endregion
            #region Datetime hazir metotları
            var tarih = DateTime.Now;
            Console.WriteLine("yerel saat"+(DateTime.Now));
            Console.WriteLine("utc saat"+(DateTime.UtcNow));
            Console.WriteLine(tarih.ToShortDateString);
            Console.WriteLine(tarih.ToShortTimeString);

            //doğum tarihi belirleme
            DateTime dogumTarihi = new DateTime(1999,4,15);

            DateTime okulaBaslamaTarihi = dogumTarihi.AddYears(7);
            DateTime ortaOkulTarihi=okulaBaslamaTarihi.AddYears(4);
            Console.WriteLine("zilan doğum gunu:" + dogumTarihi.DayOfWeek);
            Console.WriteLine("zilan doğum gunu yılın kacıncı gunu:" + dogumTarihi.DayOfYear);
             Console.WriteLine(DateTime.IsLeapYear(dogumTarihi.Year));
            #region  iki tarih arasındaki farklar
            TimeSpan timeSpan = DateTime.Now - dogumTarihi;

            Console.WriteLine("Zilan  => " + timeSpan.Days + " gundur hayatta");

            TimeSpan performans = DateTime.Now - baslangic;
          
            Console.WriteLine("Programin Calisma suresi (milisaniye): " + performans.TotalMilliseconds);
            Console.WriteLine("Programin Calisma suresi (saniye): " + performans.TotalSeconds);
            #endregion

            #endregion

        }
        public static string Sansur(string str)
        {
            List<string> yasakliKelimeler = new List<string>();
            yasakliKelimeler.Add("dolayı");
            yasakliKelimeler.Add("sentezdir");
            yasakliKelimeler.Add("Toplumları");
            yasakliKelimeler.Add("Bütün");

            foreach(var kelime in yasakliKelimeler )
            {
                if (str.Contains(kelime))
                {
                    string yildiz = "";
                    for(int i = 0;i< kelime.Length; i++)
                    {
                        yildiz += "*";
                    }
                    str= str.Replace(kelime,yildiz);
                }
            }
            return str;
        }
    }
}