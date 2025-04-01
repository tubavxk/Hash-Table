using System;
using System.Collections;

class kisiyönetim
{
    static Hashtable kisiler = new Hashtable();

    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("\n*** KİŞİ YÖNETİM SİSTEMİ ***");
                Console.WriteLine("1 - Kişi Ekle");
                Console.WriteLine("2 - Kişi Sil");
                Console.WriteLine("3 - Tüm Kişileri Yazdır");
                Console.WriteLine("4 - Kişi Sayısını Bul");
                Console.WriteLine("5 - Kişi Ara");
                Console.WriteLine("6 - Çıkış");
                Console.Write("Seçiminizi yapın: ");

                if (!int.TryParse(Console.ReadLine(), out int secim))
                {
                    Console.WriteLine("Lütfen geçerli bir seçim yapın!");
                    continue;
                }

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
                        Console.WriteLine("Hatalı seçim! 1-6 arasında bir sayı giriniz.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }

    static void KisiEkle()
    {
        try
        {
            Console.Write("Eklemek istediğiniz kişinin ID'sini girin: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Geçersiz giriş! ID sadece sayı olabilir.");
                return;
            }

            if (kisiler.ContainsKey(id))
            {
                Console.WriteLine("Bu ID zaten kayıtlı! Lütfen farklı bir ID girin.");
                return;
            }

            Console.Write("Kişinin adını girin: ");
            string ad = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(ad))
            {
                Console.WriteLine("Geçersiz giriş! Ad boş olamaz.");
                return;
            }

            kisiler.Add(id, ad);
            Console.WriteLine($"ID: {id}, Ad: {ad} başarıyla eklendi.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }

    static void KisiSil()
    {
        try
        {
            Console.Write("Silmek istediğiniz kişinin ID'sini girin: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Geçersiz giriş! ID sadece sayı olabilir.");
                return;
            }

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
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }

    static void KisileriYazdir()
    {
        try
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
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }

    static void KisiSayisiniBul()
    {
        try
        {
            Console.WriteLine($"Toplam kayıtlı kişi sayısı: {kisiler.Count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }

    static void KisiAra()
    {
        try
        {
            Console.Write("Aramak istediğiniz kişinin ID'sini girin: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Geçersiz giriş! ID sadece sayı olabilir.");
                return;
            }

            if (kisiler.ContainsKey(id))
            {
                Console.WriteLine($"ID: {id} bulundu! Adı: {kisiler[id]}");
            }
            else
            {
                Console.WriteLine("Bu ID ile kayıtlı kişi bulunamadı.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }
}
