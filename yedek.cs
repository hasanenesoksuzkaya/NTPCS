/using System;

//namespace Project1
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Ayın Kaçıncı Günü : ");
//            int aGunu = int.Parse(Console.ReadLine());

//            if (aGunu <= 0 || aGunu > 31)
//            {
//                Console.WriteLine("Lütfen 1 ile 31 arasında geçerli bir gün sayısı giriniz.");
//                return;
//            }

//            int gun = aGunu % 7;
//            if (gun == 0) gun = 7;

//            switch (gun)
//            {
//                case 1:
//                    Console.WriteLine("Pazartesi");
//                    break;
//                case 2:
//                    Console.WriteLine("Salı");
//                    break;
//                case 3:
//                    Console.WriteLine("Çarşamba");
//                    break;
//                case 4:
//                    Console.WriteLine("Perşembe");
//                    break;
//                case 5:
//                    Console.WriteLine("Cuma");
//                    break;
//                case 6:
//                    Console.WriteLine("Cumartesi");
//                    break;
//                case 7:
//                    Console.WriteLine("Pazar");
//                    break;
//                default:
//                    Console.WriteLine("Ayın kaçındasın diye sormuştum.");
//                    break;
//            }
//        }
//    }
//}

using System;
using System.Text;

class Program
//{
//    static void Main()
//    {
//        Console.Write("Bir sayı girin: ");
//        Int64 sayi = Convert.ToInt64(Console.ReadLine());

//        Console.WriteLine($"1 ile {sayi} arasındaki asal sayılar:");

//        StringBuilder asalSayilar = new StringBuilder();

//        for (Int64 sayiAdim = 2; sayiAdim <= sayi; sayiAdim++)
//        {
//            if (AsalMi(sayiAdim))
//            {
//                if (asalSayilar.Length > 0)
//                    asalSayilar.Append(", ");

//                asalSayilar.Append(sayiAdim);
//            }
//        }

//        Console.WriteLine(asalSayilar.ToString());
//    }

static bool AsalMi(Int64 sayi)
{
    if (sayi < 2)
        return false;

    for (Int64 i = 2; i * i <= sayi; i++)
    {
        if (sayi % i == 0)
            return false;
    }

    return true;
}
    }
}
}
