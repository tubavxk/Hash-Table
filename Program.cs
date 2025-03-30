using System;
using System.Collections;

class KisiYonetim
{
    static Hashtable kisiler = new Hashtable();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n*** KİŞİ YÖNETİM SİSTEMİ ***");
            Console.WriteLine("1 - Kişi Ekle");
            Console.WriteLine("2 - Kişi Sil");
            Console.WriteLine("3 - Tüm Kişileri Yazdır");
            Console.WriteLine("4 - Kişi Sayısını Bul");
            Console.WriteLine("5 - Kişi Ara");
            Console.WriteLine("6 - Çıkış");
            Console.Write("Seçiminizi yapın: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    KisiEkle();
                    break;
                case 2:
                    KisiSil();
                    break;
                case 3:
                    KisileriYazdir();
                    break;
                case 4:
                    KisiSayisiniBul();
                    break;
                case 5:
                    KisiAra();
                    break;
                case 6:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Hatalı seçim! Tekrar deneyin.");
                    break;
            }
        }
    }

    // 1️⃣ Kişi Ekleme Fonksiyonu
    static void KisiEkle()
    {
        Console.Write("Eklemek istediğiniz kişinin ID'sini girin: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (kisiler.ContainsKey(id))
        {
            Console.WriteLine("Bu ID zaten kayıtlı! Lütfen farklı bir ID girin.");
            return;
        }

        Console.Write("Kişinin adını girin: ");
        string ad = Console.ReadLine();

        kisiler.Add(id, ad);
        Console.WriteLine($"ID: {id}, Ad: {ad} başarıyla eklendi.");
    }

    // 2️⃣ Kişi Silme Fonksiyonu
    static void KisiSil()
    {
        Console.Write("Silmek istediğiniz kişinin ID'sini girin: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (kisiler.ContainsKey(id))
        {
            kisiler.Remove(id);
            Console.WriteLine($"ID {id} başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Bu ID bulunamadı!");
        }
    }

    // 3️⃣ Tüm Kişileri Yazdırma Fonksiyonu
    static void KisileriYazdir()
    {
        if (kisiler.Count == 0)
        {
            Console.WriteLine("Kişi listesi boş!");
            return;
        }

        Console.WriteLine("\n--- Kayıtlı Kişiler ---");
        foreach (DictionaryEntry kisi in kisiler)
        {
            Console.WriteLine($"ID: {kisi.Key}, Ad: {kisi.Value}");
        }
    }

    // 4️⃣ Kişi Sayısını Bulma Fonksiyonu
    static void KisiSayisiniBul()
    {
        Console.WriteLine($"Toplam kayıtlı kişi sayısı: {kisiler.Count}");
    }

    // 5️⃣ Kişi Arama Fonksiyonu
    static void KisiAra()
    {
        Console.Write("Aramak istediğiniz kişinin ID'sini girin: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (kisiler.ContainsKey(id))
        {
            Console.WriteLine($"ID: {id} bulundu! Adı: {kisiler[id]}");
        }
        else
        {
            Console.WriteLine("Bu ID ile kayıtlı kişi bulunamadı.");
        }
    }
}
