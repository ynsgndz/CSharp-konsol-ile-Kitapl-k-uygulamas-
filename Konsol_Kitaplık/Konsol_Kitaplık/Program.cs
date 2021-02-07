using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Konsol_Kitaplık
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamFiyat = 0;
            string secim;
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türçe Kitaplar Kategorisi            **      Yabancı Kitaplar Kategorisi   **");
            Console.WriteLine();
            Console.WriteLine("**  1- Çalıkuşu: Reşat Nuri              **  7-Tuna Kılavuzu: Jules Verne      **");
            Console.WriteLine();
            Console.WriteLine("**  2- Yaban: Yakup Kadri                **  8-Bir Kuzey Macerası: Jack London **");
            Console.WriteLine();
            Console.WriteLine("**  3- Sinekli Bakkal: Halide Edip       **  9-Altıncı Koğuş: Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("**  4- Tehlikeli Oyunlar: Oğuz Atay      **  10-Kumarbaz: Dostoyevski          **");
            Console.WriteLine();
            Console.WriteLine("**  5- Geçtiğim Günlerden: Hasan A.Yücel **  11-İki şehrin Hikayesi: C.Dickens **");
            Console.WriteLine();
            Console.WriteLine("**  6- Kuyucaklı Yusuf: Sabahattin Ali   **  12-Vişne Bahçesi: Anton Çehov     **");
            Console.WriteLine();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine();

            Console.WriteLine("*****İşlemler Menüsü*****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine("7-Kayıtlı okurlar");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz İşlem Numarasını giriniz: ");

            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Fiyatını öğrenmek istediğiniz kitap numarasını giriniz : ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.WriteLine("Çalıkuşu: 12TL"); break;
                    case "2": Console.WriteLine("Yaban: 14TL"); break;
                    case "3": Console.WriteLine("Sinekli bakkal: 16TL"); break;
                    case "4": Console.WriteLine("Tehlikeli oyunlar: 11TL"); break;
                    case "5": Console.WriteLine("Geçtiğim günler: 8TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yufus: 13TL"); break;
                    case "7": Console.WriteLine("Tuna kılavuzu: 12TL")  ;break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası: 17TL");  break;
                    case "9":; Console.WriteLine("Altıncı koğuş: 5TL"); break;
                    case "10": Console.WriteLine("Kumarbaz: 10TL");  break;
                    case "11": Console.WriteLine("İki şehrin hikayesi: 13TL");  break;
                    case "12": Console.WriteLine("Vişne Bahçes: 16TL");  break;
                    default: Console.WriteLine("Böyle bir kitap mevcut değil, tekrar deneyin");break;
                }
            }
            if (islem == '2')
            {

                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.WriteLine("Adınız:");
                ad=Console.ReadLine();
                Console.WriteLine("Soyadınız:");
                soyad = Console.ReadLine();
                Console.WriteLine("Üniversiteniz:");
                universite = Console.ReadLine();

                string dosyaYolu = @"C:\Users\yns3g\Desktop\uyeler.txt";
                StreamWriter sw = new StreamWriter(dosyaYolu);
                sw.WriteLine("Adınız: "+ad);
                sw.WriteLine("Soyadınız: "+soyad);
                sw.WriteLine("Üniversiteniz: "+universite);
                sw.Close();


                // C:\Users\yns3g\Desktop\Ekran Alıntısı.PNG


            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün Kitabı : Çalıkuşu ****");
                Console.WriteLine();
                Console.WriteLine("************************************");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\yns3g\Desktop\kitaplar.txt",FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
            }
            if (islem == '5')
            {
                for (int i = 0; i <=100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitabın numarası: ");
                    secim = Console.ReadLine();
                    if (secim=="1")
                    {
                        toplamFiyat = toplamFiyat + 12;

                    }
                    else if(secim=="2")
                    {
                        toplamFiyat = toplamFiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplamFiyat = toplamFiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplamFiyat = toplamFiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplamFiyat = toplamFiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplamFiyat = toplamFiyat + 12;
                    }
                    else if (secim == "7")
                    {
                        toplamFiyat = toplamFiyat + 14;
                    }
                    else if (secim == "8")
                    {
                        toplamFiyat = toplamFiyat + 12;

                    }
                    else if (secim == "9")
                    {
                        toplamFiyat = toplamFiyat + 14;
                    }
                    else if (secim == "10")
                    {
                        toplamFiyat = toplamFiyat + 16;
                    }
                    else if (secim == "11")
                    {
                        toplamFiyat = toplamFiyat + 11;
                    }
                    else if (secim == "12")
                    {
                        toplamFiyat = toplamFiyat + 8;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap numarası yok !");
                        Console.WriteLine();
                        Console.Write("Başka bir kitap almak istermisiniz ? (e/h)");
                        string cevap = Console.ReadLine();
                        
                        if (cevap=="h"||cevap=="H")
                        {
                            break;
                        }
                    
                    
                    
                }
                Console.WriteLine("Toplam tutar: " + toplamFiyat);



            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1,100);
                while (sayi!=tahmin)
                {
                    Console.Write("Tahmini Sayınızı giriniz -> ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin>sayi)
                    {
                        Console.WriteLine(" Sayıyıdan büyük girdiniz ");
                    }
                    if (tahmin < sayi)
                    {
                        Console.WriteLine("Sayıdan küçük girdiniz: ");
                    }
                        if (tahmin == sayi)
                        {
                        Console.WriteLine("Tebrikler sayıyı bildiniz -> "+sayi);
                        break;
                        }
                    {

                    }
                }
            }
            if (islem == '7')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("***** Kayıtlı okurların listesi  ****");
                FileStream xFs = new FileStream(@"C:\Users\yns3g\Desktop\uyeler.txt",FileMode.Open,FileAccess.Read);
                StreamReader xSr = new StreamReader(xFs);
                string okumaIslemi = xSr.ReadLine();
                while (okumaIslemi!=null)
                {
                    Console.WriteLine(okumaIslemi);
                    okumaIslemi = xSr.ReadLine();
                }
                xSr.Close();
                xFs.Close();
                Console.WriteLine();
                Console.WriteLine("************************************");
            }










            Console.Read();
        }
    }
}
