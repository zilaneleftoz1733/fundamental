using System;

namespace DegiskenTanimlama
{
    public class Program 
    {
         static int yas =20;
        
        public static void Main(string[] args)
        {
        
            #region DEgiskenlerin Deger Araliklari
            System.Console.WriteLine("Degisken Uzunluklari");
            System.Console.WriteLine("Byte ......");// byte kapinumarasi
            System.Console.WriteLine(byte.MinValue + " " + byte.MaxValue);
            
            System.Console.WriteLine("short ......"); //short ogrencino
            System.Console.WriteLine(short.MinValue + " " + short.MaxValue);
     
            System.Console.WriteLine("unsign short ......");// ushort
            System.Console.WriteLine(ushort.MinValue + " " + ushort.MaxValue);
          

            System.Console.WriteLine("int  ......"); // int sayi
            System.Console.WriteLine(int.MinValue + " " + int.MaxValue);
            System.Console.WriteLine("uint  ......");
            System.Console.WriteLine(uint.MinValue + " " + uint.MaxValue);

            System.Console.WriteLine("long  ......");// long
            System.Console.WriteLine(long.MinValue + " " + long.MaxValue);
            System.Console.WriteLine("ulong  ......");
            System.Console.WriteLine(ulong.MinValue + " " + ulong.MaxValue);

        // Küsüratli  degerler , flot(4 byte),double(8 byte),decimal(16 byte)

            System.Console.WriteLine("float  ......");// long
            System.Console.WriteLine(float.MinValue + " " + float.MaxValue);


            System.Console.WriteLine("double  ......");// long
            System.Console.WriteLine(double.MinValue + " " + double.MaxValue);
           
           System.Console.WriteLine("decimal  ......");// long
            System.Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);
            
            #endregion
            
            #region DEgisken Tanimlama Kurallari
            /*
            *  1- Degisken isimleri sayi ile başlayamaz
            *  2- reserve kelime kullanilmaz => static,void ,public v.b. 
            *  3- Ozel karakterlerden sadece _ kullanilir
            *  4- En fazla 255 karakter olabilir
            *  5- <Tip> <degiskenAdi> = <ilk deger atamasi>;
            */


            // Birlesik Kelimelerden olusan degisken isimlerindeki prensipler
            // int StokMiktari => Pascal Case
            // stokMiktari => camel case
            // stok_miktari => snake case
            // stok-miktari => kebab case

            #endregion

            #region Ornek
            // Bir ogrencinin ad ,soyad ,DogumTarihi ,ayakkabi numarasi 
            // tcno ,gsm bilgilerini temsil edecek degiskenleri tanimlayalim
            string ad="Ali",soyad;
            DateTime DogumTarihi;
            DateTime Bugun = DateTime.Now;//ilk deger atamasi
            byte ayakkabiNumarasi=42;
            string tcno = "12345678901";
            System.Console.WriteLine(tcno.Substring(7));
            //tcno.ToString().Substring(8,11);

            string gsm="+90532 111 22 33";
            #endregion
            
            // Runtime sirasinda tipi belirleme
            var temp = "12";
            System.Console.WriteLine(temp);
            
            
            #region Küsürlü sayilar

            var sayi = 12.3;// Default olarak  double olur,float icin f ,decimal icin m eklenir

            System.Console.WriteLine(sayi);
            #endregion 

            #region Sabitler
            const float pi=3.14F;
             // pi=4.56f; const degiskenlere sonradan deger atamasi yapilamaz

            System.Console.WriteLine(pi);
            #endregion


            #region DEgiskenlerin yaşam Omrü
            {
                string email = "ali@gmail.com";
                System.Console.WriteLine(yas);
                System.Console.WriteLine(email);  
                {
                    int sayi1=10;
                    System.Console.WriteLine(yas);
                    System.Console.WriteLine(email);
                    System.Console.WriteLine(sayi1);
                }  
                //System.Console.WriteLine(sayi1); Hata Verecektir
            }
            // System.Console.WriteLine(email);Hata Verecektir
            // System.Console.WriteLine(sayi1);Hata Verecektir
            #endregion
            
            #region nullable degisken tanimlama ve ? 
            // bir degiskene null degerler atilabilir demek icin ? ile işsaretlemek gerekir.
            string? sehir = "";

            #endregion 
            
            Console.WriteLine("Hello, World!");
            
        }

    }
}