using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriHesaplama
{
    interface IGeometri
    {
        int KısaKenar {get; set; }
        int UzunKenar { get; set; }
        int Yükseklik { get; set; }
        int Hacim();
        int YüzeyAlanı();

    }

    class Küp : IGeometri
    {
        public int KısaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int Yükseklik { get; set; }

        public int Hacim()
        {
            
            return KısaKenar * UzunKenar * Yükseklik;
        }

        public int YüzeyAlanı()
        {
            return KısaKenar * UzunKenar * 6;
        }
    }
    class Prizma : IGeometri
    {
        public int KısaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int Yükseklik { get; set; }

        public int Hacim()
        {

            return KısaKenar * UzunKenar * Yükseklik;
        }

        public int YüzeyAlanı()
        {
            return (KısaKenar * UzunKenar) * 2 + (UzunKenar* Yükseklik)*2 + (KısaKenar * Yükseklik) * 2;
        }
    }
    class Piramit : IGeometri
    {
        public int KısaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int Yükseklik { get; set; }

        public int Hacim()
        {

            return KısaKenar * UzunKenar * Yükseklik / 3;
        }

        public int YüzeyAlanı()
        {
            return (KısaKenar * UzunKenar) + Convert.ToInt32((Math.Sqrt(KısaKenar*KısaKenar/4 + Yükseklik*Yükseklik)))*KısaKenar/2 * 4 ;
        }
    }


    internal class Program
    {

        static void Hesapla(IGeometri geometri)
        {
            Console.WriteLine("Kısa kenar uzunluğunu giriniz:");
            geometri.KısaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenar uzunluğunu giriniz:");
            geometri.UzunKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yükseklik uzunluğunu giriniz:");
            geometri.Yükseklik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Hacim: {geometri.Hacim()} \nYüzey Alanı: {geometri.YüzeyAlanı()}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hesaplamak istediğiniz geometriyi seçiniz:\n1- Küp\n2-Prizma\n3-Piramit");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    
                    IGeometri Küp1 = new Küp();
                    Hesapla(Küp1);
                    break;
                case 2:

                    IGeometri Prizma1 = new Prizma();
                    Hesapla(Prizma1);
                    break;
                case 3:

                    IGeometri Pramit1 = new Piramit();
                    Hesapla(Pramit1);
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız. 1,2 veya 3 numaralı bir seçim yapınız.");
                    break;
            }
            Console.ReadLine();
        }
    } 
}
