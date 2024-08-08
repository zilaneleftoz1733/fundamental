﻿namespace IFElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Su sıcaklığını girin (Celsius): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double sicaklik))
            {
                if (sicaklik <= 0)
                {
                    Console.WriteLine("Su katı halde (buz).");
                }
                else if (sicaklik > 0 && sicaklik < 100)
                {
                    Console.WriteLine("Su sıvı halde.");
                }
                else
                {
                    Console.WriteLine("Su gaz halde (buhar).");
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sıcaklık değeri girin.");
            }
        }

        #region If Konu Anlatimi Ornek ile 
        // int sayi1 = 5;
        // int sayi2 = 5;

        // if(sayi1 == 5) 
        // {
        //     System.Console.WriteLine("Sayi 5 dir");
        // }
        // else
        // {
        //     System.Console.WriteLine("Sayi 5 degildir");
        // }


        // if(sayi1>sayi2)
        // {

        //   System.Console.WriteLine(sayi1 +" > " +sayi2);  
        // }
        // else if(sayi1==sayi2)
        // {
        //     System.Console.WriteLine(sayi1 +" = " +sayi2);
        // }
        // else
        // {
        //     System.Console.WriteLine(sayi1 +" < " +sayi2);
        // }
        // Console.WriteLine("Hello, World!");
        #endregion

        #region Suyun Sicakligi

        #endregion
    }
}
