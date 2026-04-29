# ✈️ TravelTripProje

ASP.NET MVC 5 ile Geliştirdiğim ilk projem. Projedeki Amacım hem gezdiğim yerleri sizlere aktarmak hemde öğrendiklerimi canlı bir şekilde uygulamak.

# Projenin Canlı Linki
http://traveltripmvc.somee.com/Default/Index/

# ⚙️ Projenin Özeti
Bu projeyi Full-Stack yolunda attığım ilk adım olarak görüyorum. Projedeki amacım ASP.NET MVC 5 mimarisindeki Model-View-Controller yapısını ve birbirinden ayrılmaz bağlantısını canlı bir şekilde uygulayarak öğrenmekti.

# 🚀 Özellikler
👤 Kullanıcı Tarafı
- Anasayfada En popüler blogları, Adminlerin Favori Bloglarını Görüntülebileyebilirler.
- Blog içeriklerini listeleyebilir
- Blog detaylarını görebilir
- Ziyaretçiler Bloglara Yorum Bırakabilir.
- İletişim Mesajı Gönderebilir.
- Rota Sayfasında Gidilebilecek yeni mekanları görebilir.

🔐 Admin Paneli
- Güvenli giriş sistemi
- Blog ekleme, güncelleme ve silme
- Yorum listeleme, güncelleme ve silme
- Adminlere ait Favori blog işaretleme

Admin Paneli Authorize Yöntemi ile Korunuyor. Bütün Blogları ve Yorumları tek bir yerden kontrol edebiliyorsunuz

Bu yapi sayesinde public taraftaki blog deneyimi ile yonetim operasyonlari birbirinden ayrilarak daha duzenli bir mimari elde edilir.

# 🛠️ Kullanılan Teknolojiler
- C# 
- ASP.NET MVC 5 (Model-View-Controller mimarisi)
- MSSQL Server Bağlantısı
- Entity Framework — Code First & Migration
- DbContext ile veritabanı yönetimi
- IEnumerable & Enum kullanımı
- PageList.MVC Entegrasyonu
- PartialView Kullanımı
- Hazır tema üzerine tamamen dinamik içerik entegrasyonu

# ⚙️ Kurulum
1. Repoyu klonla
git clone https://github.com/kullanici-adi/easy-trip.git

3. Veritabanını oluştur
Visual Studio'da Package Manager Console'u aç:

Update-Database

3. Projeyi çalıştır
Visual Studio'da F5 veya IIS Express ile başlat

# 📌 Notlar
- View katmanında hazır tema kullanılmıştır, tüm içerikler veritabanından dinamik olarak çekilmektedir.
- Bu proje MVC mimarisini öğrenme sürecinde geliştirilmiştir.

# 🖼️ Ekran Görüntüleri

Anasayfa
<img width="1600" height="760" alt="Anasayfa1" src="https://github.com/user-attachments/assets/2c759f38-785c-4ac6-a002-fc6d987742b2" />

Anasayfa 2
<img width="1600" height="751" alt="Anasayfa2" src="https://github.com/user-attachments/assets/c05c054f-6cc0-4796-8fba-6b2a6e829db1" />

Hakkımızda
<img width="1600" height="686" alt="Hakkımızda" src="https://github.com/user-attachments/assets/3e00b326-837a-49e1-bc8d-2679256250a9" />

Rotamız
<img width="1600" height="750" alt="Rota" src="https://github.com/user-attachments/assets/bbd998d9-3229-4e80-ba6a-8b5c86c95265" />

Blog 1
<img width="1600" height="757" alt="Blog1" src="https://github.com/user-attachments/assets/05aa13fe-72a7-4cd0-a274-afbeb264b409" />

Blog 2
<img width="1600" height="707" alt="Blog2" src="https://github.com/user-attachments/assets/b6cd5e9e-6684-458a-aeed-16b2e39eea07" />

Blog Detay 1
<img width="1600" height="761" alt="Blog Detay1" src="https://github.com/user-attachments/assets/54c44b62-c6a3-43b8-897d-5d75a66e9fa9" />

Blog Detay 2
<img width="1600" height="742" alt="Blog Detay2" src="https://github.com/user-attachments/assets/b1851dad-5248-427d-89d0-836956165017" />

İletişim
<img width="1600" height="761" alt="iletisim" src="https://github.com/user-attachments/assets/62efbc26-91cd-419b-b652-cc37b34f9a75" />

Admin Giriş
<img width="1600" height="760" alt="AdminGiris" src="https://github.com/user-attachments/assets/c54a22be-3986-462b-a170-1c4643824af1" />

Admin Blog Listesi
<img width="1600" height="758" alt="AdminBlogListe" src="https://github.com/user-attachments/assets/6b543efb-5c6e-4176-8efb-5aee807bfdb1" />

Admin Yorum Listesi
<img width="1600" height="759" alt="AdminYorumListe" src="https://github.com/user-attachments/assets/5c30b644-cce7-4b31-8cfa-03839ddc220c" />

