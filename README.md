# 📦 C# Stok Takip & Veri Yönetim Sistemi

Bu proje, C# dili kullanılarak geliştirilmiş, verilerini fiziksel bir `.txt` dosyasında saklayan ve yöneten temel bir stok takip uygulamasıdır. Yazılım geliştirme sürecimde **dosya işlemleri (I/O)**, **veri manipülasyonu** ve **hata yönetimi** konularındaki yetkinliklerimi sergilemek amacıyla hazırlanmıştır.

## 🚀 Özellikler

- **Dosya Tabanlı Depolama:** Veriler `stok.txt` dosyasında kalıcı olarak saklanır.
- **Akıllı Stok Güncelleme:** Aynı ürün tekrar eklendiğinde yeni satır oluşturmak yerine mevcut miktarı otomatik olarak artırır.
- **Dinamik Veri İşleme:** Kullanıcıdan alınan kirli verileri (`Trim`, `ToLower`) temizleyerek işler.
- **Hata Yönetimi:** Boş satırlara veya hatalı formatlara karşı `IndexOutOfRangeException` korumalı yapıya sahiptir.
- **Kullanıcı Dostu Menü:** Konsol üzerinden 1-Görselleştirme, 2-Ekleme/Güncelleme, 3-Çıkış seçenekleri sunar.

## 🛠️ Teknik Detaylar

Program içerisinde aşağıdaki C# yetenekleri kullanılmıştır:
- **System.IO:** `ReadAllLines`, `WriteAllLines` ve `AppendAllText` ile dosya yönetimi.
- **Collections.Generic:** Verilerin bellekte yönetilmesi için `List<string>` kullanımı.
- **String Manipulation:** `Split(':')`, `Trim()` ve `String Interpolation`.
- **Parsing:** `int.TryParse` ile güvenli tip dönüşümleri.

## 💻 Kurulum ve Çalıştırma

1. Bu depoyu klonlayın:
   ```bash
   git clone [https://github.com/musulasakc-cyber/Stok-takip.git](https://github.com/musulasakc-cyber/Stok-takip.git)
