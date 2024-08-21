namespace CustomerDosyaOkuma
{
    public struct Customer
    {
        public int index;
        public string CustomerId;
        public string FirstName;
        public string LastName;
        public string Company;
        public string City;
        public string Country;
        public string Phone1;
        public string Phone2;
        public string Email;
        public string Subscription;
        public string Date;
        public string Website;
    }
    internal class Program
    { 

        static void Main(string[] args)
        {

            var customers = ReadCustomers("C:\\Users\\lzila\\Downloads\\customers-1000\\customers-1000.csv");

            Console.WriteLine("Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"index: {customer.index},ID: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}, " +
                                  $"Company: {customer.Company}, City: {customer.City}, Country: {customer.Country}, " +
                                  $"Phone1: {customer.Phone1}, Phone2: {customer.Phone2}, Email: {customer.Email}, " +
                                  $"Subscription: {customer.Subscription}, Date: {customer.Date}, Website: {customer.Website}");
            }
        }

        private static List<Customer> ReadCustomers(string path)
        {
            List<Customer> customers = new List<Customer>();
            List<string> strings = new List<string>();

            try
            {
                string[] satirlar = File.ReadAllLines(path);

                if (satirlar.Length == 0)
                {
                    Console.WriteLine("CSV dosyasında veri bulunamadı.");
                    return customers;
                }

                
                bool isHeader = true;

                foreach (var line in satirlar)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue; 
                    }

                    var fields = line.Split(',');

                    if (fields.Length < 13) 
                    {
                        Console.WriteLine($"Hatalı satır (Eksik alanlar): {line}");
                        continue;
                    }

                    Customer customer = new Customer();

                    try
                    {
                        customer.index = int.Parse(fields[0].Replace('"', ' ').Trim());
                        customer.CustomerId = fields[1].Replace('"', ' ').Trim();
                        customer.FirstName = fields[2].Replace('"', ' ').Trim();
                        customer.LastName = fields[3].Replace('"', ' ').Trim();
                        customer.Company = fields[4].Replace('"', ' ').Trim();
                        customer.City = fields[5].Replace('"', ' ').Trim();
                        customer.Country = fields[6].Replace('"', ' ').Trim();
                        customer.Phone1 = fields[7].Replace('"', ' ').Trim();
                        customer.Phone2 = fields[8].Replace('"', ' ').Trim();
                        customer.Email = fields[9].Replace('"', ' ').Trim();
                        customer.Subscription = fields[10].Replace('"', ' ').Trim();
                        customer.Date = fields[11].Replace('"', ' ').Trim();
                        customer.Website = fields[12].Replace('"', ' ').Trim();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Format hatası: {ex.Message} - Satır: {line}");
                        continue;
                    }

                    customers.Add(customer);
                }
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Dosya yolu çok uzun: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Hata: Aradığınız dosyaya şu an ulaşılamadı: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hata: Aradığınız klasöre ulaşılamadı: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            return customers;
        }
    }
}
//C:\\Users\\lzila\\Downloads\\customers-1000\\customers-1000.csv