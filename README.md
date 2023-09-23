# HumanResourceProject

Bu proje, MVC (Model-View-Controller) mimarisi kullanılarak geliştirilen ve ASP.NET Core 6, Identity ve Entity Framework Core teknolojilerini içeren bir İnsan Kaynakları Yönetim Sistemi'ni tanıtır. Bu sistem, işletmelerin insan kaynakları yönetimini kolaylaştırmak ve optimize etmek amacıyla tasarlanmıştır.

## Özellikler

- *Kullanıcı Yönetimi:* Kullanıcılar kayıt olabilir ve giriş yapabilirler. Sistem, yetkilendirme ve kimlik doğrulama işlemleri için ASP.NET Identity kullanır.

- *Admin Paneli:* Yöneticiler, sistemde özel yetkilere sahip olarak oturum açabilirler. Admin paneli, şirketlerin ve şirket yöneticilerinin yönetimi için kullanılır. Yeni şirketler eklemek, mevcut verileri düzenlemek ve işlemleri takip etmek gibi işlemler burada yapılabilir.

- *Şirketler ve Yöneticiler:* Şirket yöneticileri, şirketlerin işlemlerini takip edebilirler. Personel yönetimi, izinler, avanslar ve iş ekleme gibi işlemler burada gerçekleştirilir.

- *Personel İşlemleri:* Personeller, izin talepleri, avans talepleri ve harcamalar gibi işlemleri yapabilirler. İşlem geçmişlerini takip edebilirler.

- *Konum ve Hava Durumu Bilgisi:* RapidAPI kullanarak anlık konum bilgisi alınır ve kullanıcıdan izin alınır. Alınan konum bilgisine göre hava durumu bilgisi sunulur.

- *Döviz Kuru Bilgisi:* Proje, dolar kuru bilgisini çekmek için API'ler kullanır.

## Kullanılan Teknolojiler

- *Backend:* C# ile ASP.NET Core 6 kullanıldı.
- *Veritabanı:* Azure üzerinde bulunan bir bulut veritabanı kullanıldı.
- *ORM (Object-Relational Mapping) Aracı:* Entity Framework Core kullanıldı.
- *Frontend:* HTML, CSS, Bootstrap ve JavaScript kullanıldı.
- *Mimari:* Onion Mimarisi
