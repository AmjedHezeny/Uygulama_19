using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_19
{
    internal class Metodlar
    {
        //***************************** Soru 1 Metodlar ****************************************//

        public double FarkiniAl(double sayi1, double sayi2)
        {
            double sayilarinFarki = sayi1 - sayi2;
            return sayilarinFarki;
        }

        //***************************** Soru 2 Metodlar ****************************************//

        public int ToplamaIslemi(int[] sayilar)
        {
            int toplam = 0;
            foreach (int i in sayilar)
            {
                toplam += i;

            }
            return toplam;
        }
        public void ToplamiveOrtalamayiYazdir(int tplm, int adet)
        {
            Console.WriteLine("Sayıların Toplamı = " + tplm);
            Console.WriteLine("Sayıların Ortalaması = " + (double)tplm / adet);
        }

        //***************************** Soru 3 Metodlar ****************************************//

        public string StringIste(string baslik)
        {
            string text = string.Empty;
            bool hata = true;
            do
            {
                Console.Write(baslik);
                text = Console.ReadLine();
                if (text.Length == 0)
                {
                    Console.WriteLine("String değeri boş bırakılamaz");
                    hata = true;
                }
                else
                {
                    hata = false;
                }

            } while (hata);
            return text;

        }

        //***************************** Soru 4 Metodlar ****************************************//

        public int Topla(int[] kullanicininSayilari)
        {
            int toplam = 0;
            foreach (int i in kullanicininSayilari)
            {
                toplam += i;
            }
            return toplam;
        }

        public double Ortalama(int toplam, int adet)
        {
            double ort = (double)toplam / adet;
            return ort;

        }

        public void EnKucuk(int[] sayilar)
        {
            Array.Sort(sayilar);
            Console.WriteLine("Sayıların En Küçüğü : " + sayilar[0]);
        }
        public void EnBuyuk(int[] sayilar)
        {
            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            Console.WriteLine("Sayıların En Büyüğü : " + sayilar[0]);
        }

        //***************************** Soru 5 Metodlar ****************************************//

        public void Hesapla(int s1, int s2)
        {
            Console.WriteLine("Geçerli Bir İşlem Türü Girmediğiniz İçin Sayılar Toplanacak");
            Console.WriteLine("Sayıların Toplamı = " + (s1 + s2));
        }
        public void Hesapla(int s1, int s2, string islemTuru)
        {
            string format = "{0} {1} {2} = {3}";
            double sonuc = 0;
            switch (islemTuru)
            {
                case "+":
                    sonuc = s1 + s2;
                    break;
                case "-":
                    sonuc = s1 - s2;
                    break;
                case "*":
                    sonuc = s1 * s2;
                    break;
                case "/":
                    sonuc = (double)s1 / s2;
                    break;

            }
            Console.WriteLine(format, s1, islemTuru, s2, sonuc);
        }

        //***************************** Soru 6 Metodlar ****************************************//

        public void Topla(int s1, int s2)
        {
            Console.WriteLine("1.Metod");
            Console.WriteLine(s1 + s2);
            Console.WriteLine("--------------------");
        }
        public void Topla(int s1, int s2, int s3)
        {
            Console.WriteLine("2.Metod");
            Console.WriteLine(s1 + s2 + s3);
            Console.WriteLine("----------------------");
        }
        public void Topla(double s1, double s2)
        {
            Console.WriteLine("3.Metod");
            Console.WriteLine(s1 + s2);
            Console.WriteLine("----------------------");
        }
        public void Topla(double s1, double s2, double s3)
        {
            Console.WriteLine("4.Metod");
            Console.WriteLine(s1 + s2 + s3);
            Console.WriteLine("----------------------");
        }
        public void Topla()
        {
            Console.WriteLine("Parametre Girmediğiniz İçin Herhangi bir Sayı Toplanmadı");
        }
    }
}