using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class program1
    {
        static void Main(string[] args)
        {
            int bolunen, bolen ,kalan, bolum;
            float sonuc;

            Console.WriteLine("Bölünen Sayıyı Giriniz : ");
            bolunen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bölen Sayıyı Giriniz  : ");
            bolen = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            sonuc = (float)bolunen / (float)bolen;
            bolum = bolunen / bolen;
            kalan = bolunen % bolen;

            if (bolen != 0)
            {

                if (kalan == 0)
                {
                    Console.WriteLine($"{bolunen}/{bolen}={bolum} Bölen Bölünene Tam Bölünüyor.");
                }
                else
                {
                    Console.WriteLine($"{bolunen}/{bolen}={sonuc} Bölen Bölünene Tam Bölünmüyor. Bölüm:{bolum} Kalan: {kalan}");
                }
            }
            else
            {
                Console.WriteLine("Bir Sayıyı Sıfıra Bölemem Ama İstersen Sen Bir Dene :).");
            }

        }


    }
}
