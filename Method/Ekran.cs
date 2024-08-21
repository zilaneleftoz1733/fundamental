using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Ekran
    {
        public static int SayiOku(string mesaj)
        {
            int sayi;
            bool sonuc = true;
            do
            {
                Console.WriteLine(mesaj);
                sonuc = int.TryParse(Console.ReadLine(), out sayi);

            } while (!sonuc);
            return sayi;
        }
        public static void EkranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        public static void EkraniTemizle()
        {
            Console.Clear();
        }
        public static void SatirBasiYap()
        {
            Console.WriteLine();
        }
    }
}
