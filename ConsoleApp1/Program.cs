using System;
using System.IO;
using System.Collections.Generic;
using System.Linq.Expressions;

class StokSistemi
{
    static string dosyaYolu = "stok.txt"; 
    static void Main()
    {
        Console.WriteLine("Lütfen seçim yapınız(1,2,3)");
        Console.WriteLine("1-Güncel stok durumu,2-Yeni ürün ekle, 3-Çıkış");
        
        
       
        bool kontrol = true;
        while(kontrol){
        string seçim = Console.ReadLine() ?? "";
        switch (seçim)
        {
            case "1":
                Console.WriteLine("...Depodaki ürünler listeleniyor...");
                StoklariListele();
                break;
            case "2":
                Console.Write("Eklenecek Ürün Adı: ");
                string urun = (Console.ReadLine() ?? "").Trim();

                Console.Write("Miktarı: ");
                if (int.TryParse((Console.ReadLine()?? "").Trim(), out int miktar))
                {
                    StokGuncelle(urun, miktar); 
                }
                else
                {
                Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz!");
                }
                break;
            case "3":
                Console.WriteLine("Programdan çıkılıyor.");
                kontrol = false;
                break;
            default:
                Console.WriteLine("Geçersiz bir seçim yaptınız!");
                break;
           
        }
        
        }

    }
    static void StoklariListele()
    {
        if (File.Exists(dosyaYolu))
        {
            string [] satirlar = File.ReadAllLines(dosyaYolu);
            Console.WriteLine("Mevcut Stoklar:");
            foreach (var satir in satirlar)
            {
                string [] ürün = satir.Split(':');
                string urunadi = ürün[0];
                int stok_durumu = int.Parse(ürün[1]);
                Console.WriteLine($"{urunadi} ürününden {stok_durumu} adet var");                
            }
        }
    }

    static void StokGuncelle(string ad, int yeniMiktar)
    {
        List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
        bool urunBulundu = false;

        for (int i = 0; i < satirlar.Count; i++)
        {
            string[] parcalar = satirlar[i].Split(':');
            if (parcalar[0].ToLower() == ad.ToLower())
            {
                
                int eskiMiktar = int.Parse(parcalar[1]);
                int toplamMiktar = eskiMiktar + yeniMiktar;

                satirlar[i] = $"{parcalar[0]}:{toplamMiktar}";
                urunBulundu = true;
                break;
            }
        }

        
        if (!urunBulundu)
        {
            satirlar.Add($"{ad}:{yeniMiktar}");
        }

        File.WriteAllLines(dosyaYolu, satirlar);
        Console.WriteLine("İşlem başarıyla tamamlandı.");
    }

}

    
