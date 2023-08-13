using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Uygulama_10
    {
        static void Main(string[] args)
        {

            ////soru 1
            int sayı1, faktoriyel = 1;
            ////soru 2
            int sayı2;
            ////soru 3
            int sayı3;
            int kontrol = 0;
            string giris;
            ////soru 4
            int sayı4;
            int sayı5;
            int en_buyuk_ortak = 0;
            //// soru 5
            int sayı6;
            //// soru 6
            string metin, ters_metin;


            ////genel
            string soru, cevap;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(1).Faktöriyel Hesaplama Programı: Kullanıcının girdiği bir sayının faktöriyelini \r\nhesaplayan bir program yazınız.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).Tek ve Çift Sayı Ayırıcı Program: Kullanıcının girdiği bir sayıya kadar olan \r\ntek ve çift sayıları ayıran bir program yazınız.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).Asal Sayı Kontrol Programı: Kullanıcının girdiği bir sayının asal olup olmadığını \r\nkontrol eden bir program yazınız.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(4).En Büyük Ortak Bölen Bulma Programı: Kullanıcının girdiği iki sayının en büyük ortak \r\nbölenini hesaplayan bir program yazınız.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(5).Çarpanları Bulma Programı: Kullanıcının girdiği bir sayının \r\nçarpanlarını bulan bir program yazınız.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(6).Metni Ters Çevirme Programı: Kullanıcının girdiği bir metni tersten \r\nyazdıran bir program yazınız.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(7).Rastgele Renk Seçici Program: Bir dizi oluşturun ve içini renk isimleriyle \r\ndoldurun (en az 5 renk). Program çalıştığında, sizin için rastgele bir renk seçsin.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        Console.Write("Bir Sayi Giriniz : ");
                        sayı1 = int.Parse(Console.ReadLine());

                        for (int i = 1; i < sayı1; i++)
                        {
                            faktoriyel *= (i+1);
                        }
                        Console.WriteLine(sayı1 + "! = " + faktoriyel);

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
                        Console.Write("Bir Sayi Giriniz : ");
                        sayı2 = int.Parse(Console.ReadLine());

                        int[] sayilar = new int[sayı2];

                        for (int i = 0; i < sayı2; i++)
                        {
                            sayilar[i] = i + 1;
                        }

                        Console.Write("(1).Tek Sayılar İçin. " +
                          "\r\n(2).Çifit Sayıları İçin. \r\nBir Seçem Yapınız : ");
                        giris = Console.ReadLine();
                        Console.WriteLine("Sonuçlar:");
                        foreach (var item in sayilar)
                        {
                            if (giris == "1")
                            {
                                if (item % 2 == 1)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else if (giris == "2")
                            {
                                if (item % 2 == 0)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                            {
                                Console.WriteLine(item);
                            }
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

                else if (soru == "3")
                {
                    do
                    {
                        Console.Write("Bir Sayi Giriniz : ");
                        sayı3 = int.Parse(Console.ReadLine());

                        for (int i = 2; i < sayı3; i++)
                        {
                            if (sayı3 % i == 0)
                            {
                                kontrol++;
                                break; 
                            }
                        }

                        if (sayı3 <= 1 || kontrol != 0)
                        {
                            Console.WriteLine("Girdiğiniz Sayı Asal Değildir.");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz Sayı Asaldır.");
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


                else if (soru == "4")
                {
                    do
                    {
                        Console.Write("1.Sayıyı Giriniz : ");
                        sayı4 = int.Parse(Console.ReadLine());

                        Console.Write("2.Sayıyı Giriniz : ");
                        sayı5 = int.Parse(Console.ReadLine());

                        int Max = Math.Max(sayı4, sayı5);
                        int[] ortak_bolenler = new int[Max];

                        for (int i = 1; i <= Max; i++)
                        {
                            if (sayı4 % i == 0 && sayı5 % i == 0)
                            {
                                ortak_bolenler[i + 1] = i;
                                en_buyuk_ortak = i;
                            }
                        }

                        Console.WriteLine("En Buyuk Ortak : " + en_buyuk_ortak);
                        Console.WriteLine("Ortak Bölenler Olan Sayılar.");
                        foreach (var ortak_bolen in ortak_bolenler)
                        {
                            if (ortak_bolen != 0)
                            {
                                Console.WriteLine(ortak_bolen + "  ");
                            }
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
                        Console.Write("Bir Sayı Giriniz : ");
                        sayı6 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Sayının Çarpanları.");

                        for (int i = 1; i <= sayı6; i++)
                        {
                            if (sayı6 % i == 0)
                            {
                                Console.WriteLine(i);
                            }
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
                        Console.Write("Bir Metin Giriniz : ");
                        metin = Console.ReadLine();

                        char[] karakterler = metin.ToCharArray();
                        Array.Reverse(karakterler);
                        ters_metin = new string(karakterler);

                        Console.WriteLine("Metin Ters Çevrilmiş Hali : " + ters_metin);

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

                else if (soru == "7")
                {
                    string[] renkler = { "Kırmızı", "Mavi", "Yeşil", "Sarı", "Turuncu", 
                        "Mor", "Pembe", "Turkuaz", "Lacivert", "Beyaz" };
                    Random random = new Random();

                    do
                    {
                        int rastgeleIndex = random.Next(renkler.Length);
                        string secilenRenk = renkler[rastgeleIndex];          
                        Console.WriteLine("Rastgele Seçilen Renk : " + secilenRenk);
                        Console.WriteLine();
                        Console.Write("Devam etmek istiyor musunuz? (Evet için 'e' veya 'E', Hayır için 'h' veya 'H'): ");
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
