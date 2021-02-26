using System;
using System.Collections.Generic;

namespace _1_Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            // var liste = new List<string>()
            // {
            //     "1","2","5a","10b","abc","10","50"
            // };

            // foreach (var item in liste)
            // {
            //     try
            //     {
            //         int a = int.Parse(item);
            //         Console.WriteLine(a);
            //     }
            //     catch (Exception)
            //     {
            //         continue;
            //     }
            // }

            /****************************************************/

            // while (true)
            // {
            //     Console.WriteLine("Sayı giriniz: ");
            //     string input = Console.ReadLine();

            //     if (input == "q")
            //     {
            //         break;
            //     }

            //     try
            //     {
            //         int sayi = int.Parse(input);
            //         Console.WriteLine("Girdiğiniz sayı: {0}",sayi);
            //     }
            //     catch (Exception)
            //     {
            //         Console.WriteLine("Geçersiz sayı");
            //     }
            // }

            /****************************************************/

            Console.Write("Parola giriniz: ");
            string parola = Console.ReadLine();

            try
            {
                CheckPassword(parola);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

        }

        static void CheckPassword(string input)
        {
            string turkce_karakterler = "ğ,Ğ,ç,Ç,ş,Ş,ü,Ü,ö,Ö,ı,İ";

            foreach (char karakter in input)
            {
                if (turkce_karakterler.IndexOf(karakter) > -1)
                {
                    throw new Exception("Parola Türkçe karakter içeremez");
                }
            }
            Console.WriteLine("Geçerli parola");
        }
    }
}
