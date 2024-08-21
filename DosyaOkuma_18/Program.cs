using System.IO;

namespace DosyaOkuma_18
{
    public struct Ilce
    {
        public int IlceKodu;
        public int IlKodu;
        public string IlceAdi;
    }
    struct Sehir // Kendi Veri Tipimiz
    {
        public int plakakodu;
        public string il;
        public DateTime CreateDate;
        public bool isActive;
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            #region Dosya Okuma Islemleri

            #region Konu Anlatimi
            /*
             * Dosya Nedir ? Icersinde çeşitli bilgiler saklayan yapilara dosya denir.
             * Bilgi Turleri => metin sel veriler,ses dosyalaei,fotograf ve resim dosyalari 
             * Database dosyalari,html dosyalari ,office dosyalari v.b. 
             * 
             * Bunlar arasinda bizim en cok uzerinde duracagimiz .csv dosyalari olacaktir.
             * Csv (Comma Seperated values) veriler arasinda bir ayraç ile 
             * (Genelde ',' yada ';' olur)  ayrilmiş dosyalara  csv dosyalari denir.
             * 
             * c# da dosya okumanin bir cok yolu vardir. En hizli ve kolay olani File sinifidir.
             * 
             * 
             */
            #endregion
            #region Sehirleri okuma , Siralama Ve Ekaran yazdirma

            var sehirler = SehirleriOku();

            // //Siralama
            var sonuc = sehirler.OrderBy(p => p.plakakodu).ToList();

            // foreach (var sehir in sonuc)
            // {
            //     Console.WriteLine($"{sehir.plakakodu} => {sehir.il}");
            // } 

            sonuc.ForEach(p => Console.WriteLine($"{p.plakakodu} => {p.il}"));



            #endregion
            var ilceler = IlceleriOku(); //=> Geriye Ilceler Listesi donsun
                                         //foreach (var item in ilceler)
                                         //{
                                         //    Console.WriteLine($"{item.IlceKodu} {item.IlKodu} {item.IlceAdi}");
                                         //}

            #region Ilceler uzerinde IStanbulun ilcelerini bulalim
            //Siralama
            var ilceSonuc = ilceler.OrderBy(p => p.IlKodu).ToList();
            //foreach (var ilce in ilceler)
            //{
            //    //if (ilce.IlKodu == 34)
            //        Console.WriteLine(ilce.IlKodu + " " + ilce.IlceAdi);
            //}


            //Listelerde Arama Yapma. Izmirin ilceleri 
            var izmirIlceler = ilceler.Where(p => p.IlKodu == 35).ToList();
            izmirIlceler.ForEach(p => Console.WriteLine(p.IlKodu + " " + p.IlceAdi));
            // IStanbulda ki ilcelerin icerisinde 'B' olan ilceler hangileridir.

            var result = ilceler.Where(p => p.IlKodu == 34 && p.IlceAdi.Contains('B')).ToList();
            Console.WriteLine("IStanbuldaki Icerisinde B olan ilcelerin listesi");
            result.ForEach(p => Console.WriteLine(p.IlceAdi));

            #endregion


            #region Customer-1000.csv dosyasinin okunmasi ve listelere atilmasi



            #endregion
            #endregion
            Console.WriteLine("Hello, World!");
        }

        private static List<Ilce> IlceleriOku()
        {
            string path = "c:\\temp\\ilce.csv"; // cift backslah
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                string[] satirlar = File.ReadAllLines(path);

                foreach (var satir in satirlar)
                {
                    Ilce ilce = new Ilce(); // Sehir struct 'dan ornek alinmasi

                    var sonuc = satir.Split(','); //Gelen satiri ',' gore ayirir.
                    #region Eger Tirnaklar gorunmek istenmiyorsa 1. Yol Replace Etmektir.
                    //ilce.IlceKodu = sonuc[0].Replace('"',' ');
                    //ilce.IlKodu = sonuc[1].Replace('"', ' '); 
                    #endregion

                    #region Eger Tirnaklar gorunmek istenmiyorsa 2. Yol int cevirmektir.
                    ilce.IlceKodu = int.Parse(sonuc[0].Replace('"', ' ').Trim());
                    ilce.IlKodu = int.Parse(sonuc[1].Replace('"', ' ').Trim());
                    ilce.IlceAdi = sonuc[1].Replace('"', ' ').Trim();
                    #endregion
                    ilce.IlceAdi = sonuc[2];

                    ilceler.Add(ilce);


                }

            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Dosya yolu cok uzun:" + ex.Message);
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Hata:Aradiginiz dosyaya su an ulasilamadi:" + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hata:Aradiginiz Klasore ulasilamadi:" + ex.Message);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Hat:" + ex.Message);

            }



            return ilceler;
        }

        private static List<Sehir> SehirleriOku()
        {
            string path = "c:\\temp\\il.csv"; // cift backslah
            string path2 = @"c:\temp\il.csv"; // string verbatim

            List<string> plakalar = new List<string>();
            List<string> iller = new List<string>();

            List<Sehir> sehirler = new List<Sehir>();

            try
            {
                string[] satirlar = File.ReadAllLines(path);

                foreach (var satir in satirlar)
                {
                    Sehir sehir = new Sehir(); // Sehir struct 'dan ornek alinmasi

                    var sonuc = satir.Split(','); //Gelen satiri ',' gore ayirir.
                    sehir.plakakodu = int.Parse(sonuc[0].Replace('"', ' ').Trim());
                    sehir.il = sonuc[1].Replace('"', ' ').Trim();
                    sehir.CreateDate = DateTime.Now;
                    sehir.isActive = true;

                    #region Amele Yontemi
                    //plakalar.Add(sonuc[0]); // Ayrilan parcanin 0. Elemani plaka kodu
                    //iller.Add(sonuc[1]);// Ayrilan parcanin 1. Elemani Sehir  
                    #endregion

                    #region Modern Yontem
                    sehirler.Add(sehir);
                    #endregion
                    //Console.WriteLine(satir);
                }

                #region Amele Yontemi
                //for (int i = 0; i < plakalar.Count; i++)
                //{
                //    Console.WriteLine($"{plakalar[i]} => {iller[i]}");
                //} 
                #endregion


                //foreach (Sehir sehir in sehirler)
                //{
                //    Console.WriteLine($"{sehir.plakakodu}=>{sehir.il}\t\tKayit Zamani=>{sehir.CreateDate}\tAktifmi=>{sehir.isActive}");
                //}

            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Dosya yolu cok uzun:" + ex.Message);
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Hata:Aradiginiz dosyaya su an ulasilamadi:" + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hata:Aradiginiz Klasore ulasilamadi:" + ex.Message);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Hat:" + ex.Message);

            }
            return sehirler;
        }
    }
    
}