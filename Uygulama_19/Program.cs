using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_19
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string soru, cevap;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(1).2 adet sayı isteyelim. Talep edilen sayıların farkını daha düzgün bir şekilde ekrana yazdıralım.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).Kaç sayı gireceğini sor, ardından bu sayıları alarak toplamını ve ortalamasını hesaplayıp yazdır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).Boş olmayan metin iste, boş girdi geldiğinde tekrar talep et. Fonksiyon kullanarak yap. ");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(4).Kullanıcıdan 3 adet sayı isteyelim. Sayıları aldıktan sonra kullanıcıya bir menü ekranı sunalım.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(5).Kullanıcıdan 2 sayı al, işlem türü sor, sonucu yazdır. İşlem türü yoksa otomatik topla.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(6).Fonksiyonu tamsayılarla oluşturduk. Aynı fonksiyonla ondalık sayıları nasıl alırız.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");



                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        Console.Write("Birinci Sayıyı Giriniz : ");
                        double s1 = double.Parse(Console.ReadLine());

                        Console.Write("İkinci Sayıyı Giriniz : ");
                        double s2 = double.Parse(Console.ReadLine());

                        Metodlar metod = new Metodlar();
                        Console.WriteLine("Sayıların Farkı = " + metod.FarkiniAl(s1, s2));

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();
                }



                //***********************************************************************//

                else if (soru == "2")
                {
                    do
                    {
                        Console.Write("Kaç Adet Sayı Girmek İstiyorsunuz : ");
                        int adet = int.Parse(Console.ReadLine());

                        int[] kullaniSayilari = new int[adet];

                        for (int i = 0; i < kullaniSayilari.Length; i++)
                        {
                            Console.Write((i + 1) + ". Sayıyı Giriniz : ");
                            kullaniSayilari[i] = int.Parse(Console.ReadLine());
                        }

                        Metodlar metod = new Metodlar();
                        int toplam = metod.ToplamaIslemi(kullaniSayilari);

                        metod.ToplamiveOrtalamayiYazdir(toplam, kullaniSayilari.Length);

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();
                }



                ////***********************************************************************//

                else if (soru == "3")
                {
                    do
                    {
                        Metodlar m = new Metodlar();
                        string deger = m.StringIste("Bir Değer Giriniz : ");
                        Console.WriteLine("Girilen Değer = " + deger);
                        Console.WriteLine("Girilen Değer = " + m.StringIste("Bir Değer Giriniz : "));

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();

                }
                ////***********************************************************************//


                else if (soru == "4")
                {
                    do
                    {
                        int[] sayilar = new int[3];
                        for (int i = 0; i < sayilar.Length; i++)
                        {
                            Console.Write((i + 1) + ".Sayıyı Giriniz : ");
                            sayilar[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        Console.WriteLine("1-Sayıları Topla");
                        Console.WriteLine("2-Sayıların Ortalamasını Al");
                        Console.WriteLine("3-En Küçük Sayıyı Bul");
                        Console.WriteLine("4-En Büyük Sayıyı Bul");
                        Console.Write("Seçiminiz : ");
                        string secim = Console.ReadLine();


                        Metodlar metodlar = new Metodlar();
                        int toplam = metodlar.Topla(sayilar);
                        double ortalama = metodlar.Ortalama(toplam, sayilar.Length);


                        switch (secim)
                        {
                            case "1":
                                Console.WriteLine("Sayıların Toplamı = " + toplam);
                                break;
                            case "2":
                                Console.WriteLine("Sayıların Ortalaması = " + ortalama);
                                break;
                            case "3":
                                metodlar.EnKucuk(sayilar); break;
                            case "4": metodlar.EnBuyuk(sayilar); break;
                        }



                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }

                        else
                        {
                            Console.Clear();
                        }

                    } while (true);
                    Console.Clear();
                }


                ////***********************************************************************//

                else if (soru == "5")
                {

                    do
                    {

                        Console.Write("1. Sayıyı Girin : ");
                        int sayi1 = int.Parse(Console.ReadLine());

                        Console.Write("2. Sayıyı Girin : ");
                        int sayi2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("İşlem Türünü Seçiniz (+ , - , * , /)");
                        string secim = Console.ReadLine();

                        Metodlar islem = new Metodlar();

                        if (string.IsNullOrEmpty(secim))
                        {
                            islem.Hesapla(sayi1, sayi2);
                        }
                        else
                        {
                            islem.Hesapla(sayi1, sayi2, secim);
                        }


                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();
                }

                ////***********************************************************************//

                else if (soru == "6")
                {
                    do
                    {
                        Metodlar m = new Metodlar();

                        m.Topla(5, 9);
                        m.Topla(6, 10, 5);
                        m.Topla(5.4, 1.6);
                        m.Topla(5.7, 3.2, 9.2);
                        m.Topla();




                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();

                }


            } while (soru != "0");

            Console.WriteLine("Programdan Çıkılıyor...");
            Console.ReadKey();
        }
    }
}