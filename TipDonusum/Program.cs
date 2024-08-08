﻿namespace TipDonusum;

class Program
{
    static void Main(string[] args)
    {
        /*
        Ornek:
        Ekrandan okutulan iki sayiyi toplayalim
        */
        byte bsayi ;            Byte bsayi2;
        sbyte sbyte1;           SByte sbyte2;
        short x,y;              Int16 a,b; //short
        int sayi1,sayi2;        Int32 sayi3,sayi4;
        float fsayi1;           Single fsayi2;
        long longsayi ;         Int64 longsayi2 ;
        decimal dsayi ;         Decimal dsayi2;
        double doublesayi;      Double doublesayi2;
        string input1,input2;

        //Ekrandan bir deger okukmak icin Console.ReadLine() metodu kullanilir
        Console.WriteLine("Birinci Sayiyi Giriniz:");
        input1= Console.ReadLine();
        //tip donusumünde 1. Yol : Convert sinifini kullanmak
        sayi1 = Convert.ToInt32(input1);
        //2. Yol
        sayi1 = int.Parse(input1);
        x = (short)sayi1; //Cast , Ricada bulunmak . Daha kucuk bir tipe cevririken kullanilabilir
        doublesayi= sayi1;
        sayi2 = (int)doublesayi;
        Console.WriteLine("Ikinci Sayiyi Giriniz:");
        input2= Console.ReadLine();
        sayi2=int.Parse(input2);
        System.Console.WriteLine("String Toplami:"+input1+input2);

        System.Console.WriteLine("Numerik Toplami:"+(sayi1+sayi2));
        Console.WriteLine("Hello, World!");
    }
}