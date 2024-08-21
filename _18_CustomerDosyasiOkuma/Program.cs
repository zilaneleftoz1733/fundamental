namespace _18_CustomerDosyasiOkuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerOku() => geriye List<Customer> donecek 

            #region Sorular
            /*
             * 1- Nepal'deki musteriler
             * 2- 2020 yilina ait abonelerin listesi
             * 3- Turkiyeden kayit varmi sorgulayin. Varsi Adedini bulunuz (Count )
             * 4- web sitesi olmayan kayit varmi ?
             * 
             * 
             */
            #endregion
            var liste = CustomerOku();
            //        liste.ForEach(item => Console.WriteLine($" Müşteri index no: {item.Id} Müşteri ID: {item.CustomerId} Müşteri İsim: {item.FirstName} Müşteri Soy İsim: {item.LastName} \n Müşterinin Çalıştığı Şirket: {item.Company} Yaşadığı Şehir: {item.City} Yaşadığı Ülke: {item.Country}" +
            //$" \n 1. Telefon Numarası: {item.Phone1} 2. Telefon Numarası: {item.Phone2} Email Adresi: {item.Email} \n Abonelik Başlangıç Zamanı: {item.SubscriptionDate} Website: {item.WebSite}"));


            #region Cevaplar 
            #region Cevap 1
            // Cevap 1:
            //liste.Where(p=>p.Country.ToLower()=="nepal").ToList()
            //    .ForEach(item => 
            //        Console.WriteLine($" Id: {item.Id}  İsim: {item.FirstName}  Soy İsim: {item.LastName}  Çalıştığı Şirket: {item.Company}  Şehir: {item.City}  Ülke: {item.Country}"));


            #endregion            #region Cevap 2 : 2020 yilina iat musteriler
            #region Cevap 2
            //liste.Where(p=>p.SubscriptionDate.Year==2020).ToList()
            //    .ForEach(item =>
            //      Console.WriteLine($" Id: {item.Id}   Şirket: {item.Company}  Şehir: {item.City}  Ülke: {item.Country} Date:{item.SubscriptionDate.ToShortDateString()}"));

            #endregion

            #region Cevap 3
            //Console.WriteLine((liste.Any(p => p.Country == "Turkey"))); // Belirtilen sartta herhangi bir kayit varmi ?
            //Console.WriteLine("Turkiye den olan kayit sayisi :"+liste.Where(p=>p.Country=="Turkey").ToList().Count);
            #endregion

            #region Cevap 4
            //Console.WriteLine(liste.Any(p => string.IsNullOrEmpty(p.WebSite)));
            #region Uzun yol
            //foreach (var item in liste)
            //{
            //    if (item.WebSite == null || item.WebSite.Length == 0)
            //    {
            //        Console.WriteLine("Web site icerisinde kayit yok");
            //    }
            //}
            #endregion
            #endregion
            #endregion

            #region Odev
            /*
             * People datasini okuyun
             * Games developer sayisi nedir. 
             * En kucuk ve en buyuk yastaki developer'lari bulun
             * yas ortalamasini bulun
             * 
             */
            #endregion

            #region Game Developer Sayisi
            var result = PeopleOku();
            var gameDevelopers = result.Where(p => p.JobTitle.ToLower().Contains("developer")).ToList();
            //foreach (var item in gameDevelopers)
            //{
            //    Console.WriteLine(item.JobTitle + " "+ item.FirstName + " " + item.LastName + " " + item.DateofBirth);
            //}
            #endregion
            #region En buyuk ve En kucuk developer'larin listesi 
            //var enBuyuk = gameDevelopers.OrderBy(p=>p.DateofBirth).FirstOrDefault();
            //Console.WriteLine($"En yaşli Developer:{enBuyuk.FirstName} {enBuyuk.LastName}  {enBuyuk.DateofBirth}");
            //var enKucuk = gameDevelopers.OrderBy(p=>p.DateofBirth).LastOrDefault();
            //Console.WriteLine($"En genc Developer:{enKucuk.FirstName} {enKucuk.LastName}  {enKucuk.DateofBirth}");
            //Console.WriteLine("Yaş Ortalamasi:" + result.Average( p=>(DateTime.Now.Year - p.DateofBirth.Year)));
            //double yasOrtalama = 0;
            //double toplamYas=0;
            //foreach (var item in result)
            //{
            //    toplamYas+=(DateTime.Now.Year - item.DateofBirth.Year);
            //}
            //yasOrtalama= toplamYas/result.Count;
            //Console.WriteLine("Yaş ortalamasi :"+yasOrtalama);
            #endregion
        }
        public static List<People> PeopleOku()
        {
            List<People> people = new List<People>();

            var satirlar = File.ReadAllLines(@"c:\temp\People-1000.csv");
            for (int i = 1; i < satirlar.Length; i++)
            {
                var sutunlar = satirlar[i].Split(',');

                People person = new People();
                person.Index = int.Parse(sutunlar[0]);
                person.UserId = sutunlar[1];
                person.FirstName = sutunlar[2];
                person.LastName = sutunlar[3];
                person.Sex = sutunlar[4];
                person.Email = sutunlar[5];
                person.Phone = sutunlar[6];
                person.DateofBirth = DateTime.Parse(sutunlar[7]);
                //person.JobTitle = sutunlar[8];
                if (sutunlar.Length == 9)
                {
                    person.JobTitle = sutunlar[8].Replace(',', ' ').Trim();
                }
                else if (sutunlar.Length == 10)
                {
                    person.JobTitle = sutunlar[8].Replace('"', ' ').Trim() + ", " + sutunlar[9].Replace('"', ' ').Trim();
                }

                people.Add(person);

            }


            return people;
        }
        public static List<Customer> CustomerOku()
        {
            List<Customer> customers = new List<Customer>();
            var satirlar = File.ReadAllLines(@"c:\temp\customers-1000.csv");
            for (int i = 1; i < satirlar.Length; i++)
            {
                var sutunlar = satirlar[i].Split(',');

                Customer customer = new Customer();
                customer.Id = int.Parse(sutunlar[0]);
                customer.CustomerId = sutunlar[1];
                customer.FirstName = sutunlar[2];
                customer.LastName = sutunlar[3];
                if (sutunlar.Length == 12)
                {
                    customer.Company = sutunlar[4];
                    customer.City = sutunlar[5];
                    customer.Country = sutunlar[6];
                    customer.Phone1 = sutunlar[7];
                    customer.Phone2 = sutunlar[8];
                    customer.Email = sutunlar[9];
                    customer.SubscriptionDate = DateTime.Parse(sutunlar[10]);
                    customer.WebSite = sutunlar[11];




                }
                else
                {
                    customer.Company = sutunlar[4] + " " + sutunlar[5];
                    customer.City = sutunlar[6];
                    customer.Country = sutunlar[7];
                    customer.Phone1 = sutunlar[8];
                    customer.Phone2 = sutunlar[9];
                    customer.Email = sutunlar[10];
                    customer.SubscriptionDate = DateTime.Parse(sutunlar[11]);
                    customer.WebSite = sutunlar[12];
                }
                customers.Add(customer);
            }




            return customers;
        }
    }
    public struct People
    {
        public int Index;
        public string UserId;
        public string FirstName;
        public string LastName;
        public string Sex;
        public string Email;
        public string Phone;
        public DateTime DateofBirth;
        public string JobTitle;
    }

    public struct Customer
    {
        //Index,Customer Id,First Name,Last Name,Company,City,Country,Phone 1,Phone 2,Email,Subscription Date,Website
        public int Id;
        public string CustomerId;
        public string FirstName;
        public string LastName;
        public string Company;
        public string City;
        public string Country;
        public string Phone1;
        public string Phone2;
        public string Email;
        public DateTime SubscriptionDate;
        public string WebSite;




    }
}
