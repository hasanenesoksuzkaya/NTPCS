using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Program
    {
        static void Main(string[] args) {

            // var ogrenci = ogrBilgial();
            // ogrBilgiyazdır(ogrenci);
            // var sayilar = sayiSec();
            // Toplama(sayilar.Item1, sayilar.Item2);
            //var sayilar = sayial();
            //sirala(sayilar.Item1, sayilar.Item2, sayilar.Item3);
            hesapMakinesi();
        }
        static (string,string,string) ogrBilgial() {

            Console.Write("Adınızı Yazınız            : ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınızı Yazınız         : ");
            string soyad = Console.ReadLine();
            Console.Write("Öğrenci Numaranızı Yazınız : ");
            string no = Console.ReadLine();
            Console.Clear();

            return (ad,soyad,no);
        }

        static void ogrBilgiyazdır((string,string,string) ogrenci)
        {
            Console.WriteLine($"Öğrencinin Adı      : {ogrenci.Item1}");
            Console.WriteLine($"Öğrencinin Soyadı   : {ogrenci.Item2}");
            Console.WriteLine($"Öğrencinin Numarası : {ogrenci.Item3}");
        }


        static void Toplama(int sayi1, int sayi2) { 
            int Toplama = sayi1 + sayi2;
            Console.WriteLine($"{sayi1} + {sayi2} = {Toplama}");
        }

        static (int,int) sayiSec()
        {
            Console.Write("A sayısını Giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("B sayısını Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear() ;
            return (sayi1, sayi2);
        }

        static (int,int,int) sayial()
        {
            Console.Write("A sayısını Giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("B sayısını Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("C sayısını Giriniz : ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return (sayi1, sayi2, sayi3);
        }
        static void sirala(int sayi1, int sayi2, int sayi3)
        {
            int enbuyuksayi, ortancasayi, enkucuksayi;

            if (sayi1 >= sayi2 && sayi1 >= sayi3)
            {
                enbuyuksayi = sayi1;
                if (sayi2 >= sayi3)
                {
                    ortancasayi = sayi2;
                    enkucuksayi = sayi3;
                }
                else
                {
                    ortancasayi = sayi3;
                    enkucuksayi = sayi2;
                }
            }
            else if (sayi2 >= sayi1 && sayi2 >= sayi3)
            {
                enbuyuksayi = sayi2;

                if (sayi1 >= sayi3)
                {
                    ortancasayi = sayi1;
                    enkucuksayi = sayi3;
                }
                else
                {
                    ortancasayi = sayi3;
                    enkucuksayi = sayi1;
                }
            }
            else
            {
                enbuyuksayi = sayi3;

                if (sayi1 >= sayi2)
                {
                    ortancasayi = sayi1;
                    enkucuksayi = sayi2;
                }
                else
                {
                    ortancasayi = sayi2;
                    enkucuksayi = sayi1;
                }
            }

            Console.WriteLine($"{enbuyuksayi} > {ortancasayi} > {enkucuksayi}");
        }

        static int hesapMakinesi()
        {
            Console.Write(@"Hesap Makinesi

------------------------------------------------------------------
1 ) Toplama
2 ) Çıkartma
3 ) Çarpma
4 ) Bölme
------------------------------------------------------------------

Lütfen Bir İşlem Seçiniz : ");
            int islem = Convert.ToInt32(Console.ReadLine());
            return (islem);
        }


    }

}

        
   
