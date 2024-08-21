using Bogus;
namespace _20_DosyayaYazma
{
    

    struct Kisi
    {
        public string Ad;
        public string Soyad;
        public string Email;
        public string Ulke;
        public string Sehir;
        public string Telefon;
        public DateTime DogumTarihi;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisilistesi = new List<Kisi>();

            #region Fake data olusturma
            for (int i = 0; i < 1000; i++)
            {
                Faker faker = new Faker("tr");
                Kisi kisi = new Kisi();
                kisi.Ad = faker.Person.FirstName;
                kisi.Soyad = faker.Person.LastName;
                kisi.Ulke = "Turkiye";
                kisi.Email = faker.Person.Email;
                kisi.Sehir = faker.Person.Address.City;
                kisi.DogumTarihi = faker.Person.DateOfBirth;
                kisilistesi.Add(kisi);


            }
            kisilistesi.ForEach(kisi => Console.WriteLine($"{kisi.Ad} {kisi.Soyad} {kisi.Sehir} {kisi.DogumTarihi.ToShortDateString()}"));

            #endregion
            #region Verileri Dosyaya Yazdirma

            #region File Sinifi kullanilarak yapilmasi 
            string path = @"c:\temp\mydata.csv";
            StreamWriter streamWriter = new StreamWriter(path);
            // StreamWriter memory'deki verileri dişa bir kaynaga gondemek 
            // icin kullanilan bir Stream tipidir. Verileri parametre olarak verilen dosyaya yazar
            try
            {
                foreach (var kisi in kisilistesi)
                {
                    string data = $"{kisi.Ad};{kisi.Soyad};{kisi.Email};{kisi.Sehir};{kisi.DogumTarihi}";
                    streamWriter.WriteLine(data);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                streamWriter.Close();
            }
            DosyaOku();
            #endregion
            #endregion

        }
        public static void DosyaOku()
        {
            //Dosya Okumada 2. yontem StreamReader
            string path = @"c:\temp\mydata.csv";
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}