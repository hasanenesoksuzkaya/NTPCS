using System;

public class Program
{
    static void Main()
    {
        //double a, b,c ;
        //Console.WriteLine("a kenarını giriniz: ");
        //a = double.Parse (Console.ReadLine ());

        //Console.WriteLine("b kenarını giriniz: ");
        //b = double.Parse(Console.ReadLine());

        //c = Math.Sqrt((a * a) + (b * b));
        //Console.WriteLine(c);
        //Console.WriteLine($"Pisagorun sonucu: {c}");

        //Console.WriteLine("1-7 arasında bir sayi giriniz: (1-Pazartesi, 2-Salı..)");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //switch (sayi)
        //{
        //    case 1:
        //        Console.WriteLine("Pazartesi");
        //        break;
        //    case 2:
        //        Console.WriteLine("Salı");
        //        break;
        //    case 3:
        //        Console.WriteLine("çarşamba");
        //        break;
        //    case 4:
        //        Console.WriteLine("perşembe");
        //        break;
        //    case 5:
        //        Console.WriteLine(" bugün günlerden cuma");
        //        break;
        //    case 6:
        //        Console.WriteLine("cumartesi");
        //        break;
        //    default: 
        //        Console.WriteLine("pazar");
        //        break;

        /*
        Console.Write("bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        Console.WriteLine($"1 ile {sayi} arasındaki asal sayılar:");

        for (int num = 2; num < sayi; num++)
        {
            bool asalMi = true;


            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i==0)
                {
                    asalMi = false;
                    break;
                }
            }
            if (asalMi)
            {
                Console.Write(num + "asal sayidir");
            }
            Console.ReadKey();
        }
        */

        //Console.WriteLine("sayı gir: ");
        //int a = Convert.ToInt32(Console.ReadLine());

        //for(int i=2; i<=a; i++)
        //{ 
        //    for(int s=2; s<i; s++)
        //    {

        //        if(i%s==0)
        //        {
        //            break;
        //        }
        //        if(i%s !=0 && s==(i-1))
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //    Console.WriteLine("sayı gir: ");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($" {a} sayısına kadar olan asal sayilar aşağıda listelenmiştir");

        //for (int i = 2; i <= a; i++)
        //{
        //    if (AsalMi(i))
        //        Console.WriteLine(i + "asal sayidir");
        //}

        //}
        //static bool AsalMi(int sayi)
        //{
        //    if (sayi < 2) return false;
        //    for(int i=2; i<= Math.Sqrt(sayi); i++)
        //    {
        //        if (sayi % i == 0)
        //            return false;
        //    }
        //    return true;

        //}

        //        List<int> asalsayilar = new List<int>()
        //        {
        //            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        //        };
        //        Console.WriteLine("girilen sayidan oluşan asal sayilar");
        //       foreach(int asalsayi in asalsayilar)
        //        {
        //            for (int i = 2; i <= asalsayi; i++)
        //            {
        //                if (AsalMi(i))
        //                    Console.WriteLine(i + "asal sayidir");
        //            }

        //        }


        //    }
        //    static bool AsalMi(int sayi)
        //    {
        //        if (sayi < 2) return false;
        //        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        //        {
        //            if (sayi % i == 0)
        //                return false;
        //        }
        //        return true;

        //    }
        //}

        /*while (true)
        {
            Console.WriteLine("Sayı Giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı > 10)
            {
                Console.WriteLine("Sayı 10 dan Büyük Tebrikler");
                break;
            }
            else {
            Console.Clear();
            Console.WriteLine("Sayı 10 dan Küçük Denemeye Devam Et"); }
            
            }
            
        char secim;
        do
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 10)
            {
                Console.WriteLine("Girilen sayı 10dan büyüktür");
            }
            else
            {
                Console.WriteLine("girilen sayı 10dan küçüktür");

            }
            Console.WriteLine("Tekrar Denemek ister misiniz? E/H");
            secim = Console.ReadKey().KeyChar;
            Console.WriteLine();



        } while (secim == 'E' || secim == 'e');
        }
    }
    
        // Eğer sayı 5 olursa, özel bir mesaj verip döngüyü tamamen bitiriyorum.
        Console.WriteLine("1. Örnek: break kullanımı");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("5'e gelindi, döngüden çıkılıyor...");
                break; // 5'e gelince döngüyü sonlandır
            }

            Console.WriteLine(i);
        }

        Console.WriteLine();

        // continue kullanarak çift sayıları atlıyorum.
        Console.WriteLine("2. Örnek: continue kullanımı");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                continue; // çift sayılar atlanıyor
            }

            Console.WriteLine(i); // sadece tek sayılar yazdırılıyor
        }

        Console.WriteLine(); // Boşluk bırakıyorum
        
        // Sayaç 3’e ulaşana kadar goto komutuyla sürekli aynı yere dönüp ekrana yazdırıyorum.
        Console.WriteLine("goto kullanımı");

        int sayac = 0;

    basadon:
        Console.WriteLine("Sayaç: " + sayac);
        sayac++;

        if (sayac < 3)
        {
            goto basadon; // sayaç 3 olana kadar aynı etikete geri dön
        }

        Console.WriteLine("goto örneği bitti."); // sayaç 3 olduğunda işlem bitiyor
    }

        // Kullanıcıdan kaç terim istediğini alıyorum
        Console.Write("Fibonacci serisinin kaç terimini görmek istiyorsunuz? N : ");
        int n = Convert.ToInt32(Console.ReadLine());

        // İlk iki terimi başlangıç olarak tanımlıyorum
        int a = 1, b = 1;

        Console.WriteLine("\nFibonacci Serisi'nin ilk " + n + " terimi:");

        // Terim sayısı en az 1 ise ilk terimi yazdır
        if (n >= 1)
            Console.Write(a + " ");

        // Terim sayısı en az 2 ise ikinci terimi de yazdır
        if (n >= 2)
            Console.Write(b + " ");

        // 3. terimden itibaren hesaplamaya başlıyorum
        for (int i = 3; i <= n; i++)
        {
            int c = a + b;     // önceki iki sayının toplamı
            Console.Write(c + " ");
            a = b;             // a bir sonraki adıma taşınır
            b = c;             // b de bir sonraki adıma taşınır
        }

        Console.WriteLine();
    }
}
