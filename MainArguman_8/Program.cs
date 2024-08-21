namespace MainArguman_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
            #region Komut satirindan 2 adet sayi alalim bir adet +,-,/,* gibi bir ifade girsin 
            //Bizde girilen ifadeye gore 4 islemden birisi uygulayalim
            #endregion
            if (args.Length == 0)
            {
                Console.WriteLine("Program Kullanimi: \n <sayi1> <sayi2> <operator>\n Kullanilabilir operatorler : + - / * ");
                return;
            }

            if (!(args[2] == "+" || args[2] == "-" || args[2] == "*" || args[2] == "/"))
            {
                Console.WriteLine("Kullanabileceginiz operatorler :+ - * / ");
                return;
            }
            int sayi1, sayi2;
            bool sonuc = int.TryParse(args[0], out sayi1);
            bool sonuc2 = int.TryParse(args[1], out sayi2);


            if (sonuc == true && sonuc2 == true)
            {
                switch (args[2])
                {
                    case "+":
                        Console.WriteLine($"Toplam :{sayi1 + sayi2}");
                        break;
                    case "-":
                        Console.WriteLine($"Fark :{sayi1 - sayi2}");
                        break;
                    case "*":
                        Console.WriteLine($"CArpim :{sayi1 * sayi2}");
                        break;
                    case "/":
                        Console.WriteLine($"Toplam :{sayi1 / sayi2}");
                        break;
                    default:
                        Console.WriteLine("Beklenmedik bir durum olustu");
                        break;
                }
            }
        }
    }
}