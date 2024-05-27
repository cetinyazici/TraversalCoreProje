# Traversal Projesi

Traversal, bir turizm acentesinin müşterilerini kaydettiği, online rezervasyon yapabildiği, admin, kullanıcı ve vitrin rollerinin yer aldığı, admin ve yöneticilerin yeni tur rotaları ekleyebildiği bir uygulamadır. Bu proje, C# ve AspNet Core kullanılarak geliştirilmiştir.

## İçindekiler

- Özellikler
- Kullanılan Teknolojiler
- Kullanım
- API Kullanımı
- Veritabanı
- Kurulum
- Proje Ekran Görüntüleri
- İletişim

## Özellikler

- Müşteri kaydı ve online rezervasyon
- Admin, kullanıcı ve vitrin rolleri
- Admin ve yöneticilerin yeni tur rotaları ekleyebilme
- Güvenlik, mail konfirmasyonu ve şifre yenileme
- Kendi API'lerimizi yazma ve bu API'leri consume etme
- Rapid API verilerini kullanarak otel verilerini getirme
- Döviz ve hava durumu verilerini çekme
- Pivot sorguları kullanarak grafik oluşturma
- HTML, CSS, Bootstrap ve JavaScript ile tasarım
- Trigger kullanarak tablolardaki değişiklikleri yönetme
- SignalR ile anlık veri güncellemeleri
- Ajax ile sayfa yenilemeden veri çekme
- AutoMapper, DTO ve FluentValidation ile validasyon kontrolü
- 403, 404 gibi durum kodlarına karşılık gelen özel sayfalar
- Google Chart kullanarak raporlama
- Çoklu dil desteği

## Kullanılan Teknolojiler

- **Backend:** C#, AspNet Core
- **Frontend:** HTML, CSS, Bootstrap, JavaScript
- **Veritabanı:** SQL Server
- **Diğer:** Identity, SignalR, AutoMapper, DTO, FluentValidation, Google Chart

## Kullanım

1. Projeyi indirin veya klonlayın.
2. Proje dizinine gidin ve gerekli bağımlılıkları yükleyin.
3. Veritabanı bağlantı ayarlarını yapın.
4. Uygulamayı çalıştırın.

```bash
git clone https://github.com/cetinyazici/TraversalCoreProje.git
cd Traversal
dotnet restore
dotnet ef database update
dotnet run
```

## API Kullanımı

Proje, hem kendi yazdığımız API'leri hem de Rapid API üzerinden aldığımız verileri kullanmaktadır.

## Veritabanı

Veritabanı tasarımı ve yönetimi için SQL Server kullanılmıştır. Pivot sorguları ve triggerlar ile veritabanı işlemleri optimize edilmiştir.

## Proje Ekran Görüntüleri

![Traversal](ReadmeImages/1.png)
![Traversal](ReadmeImages/2.png)
![Traversal](ReadmeImages/3.png)
![Traversal](ReadmeImages/4.png)
![Traversal](ReadmeImages/5.png)
![Traversal](ReadmeImages/6.png)
![Traversal](ReadmeImages/7.png)
![Traversal](ReadmeImages/8.png)
![Traversal](ReadmeImages/9.png)
![Traversal](ReadmeImages/10.png)
![Traversal](ReadmeImages/11.png)
![Traversal](ReadmeImages/12.png)
![Traversal](ReadmeImages/13.png)
![Traversal](ReadmeImages/14.png)
![Traversal](ReadmeImages/15.png)
![Traversal](ReadmeImages/16.png)
![Traversal](ReadmeImages/17.png)
![Traversal](ReadmeImages/18.png)
![Traversal](ReadmeImages/19.png)
![Traversal](ReadmeImages/20.png)
![Traversal](ReadmeImages/21.png)
![Traversal](ReadmeImages/22.png)
![Traversal](ReadmeImages/23.png)
![Traversal](ReadmeImages/24.png)
![Traversal](ReadmeImages/25.png)
![Traversal](ReadmeImages/26.png)
![Traversal](ReadmeImages/27.png)
![Traversal](ReadmeImages/28.png)
![Traversal](ReadmeImages/29.png)

### İletişim

- E-posta: cetin.yazici2525@gmail.com
- LinkedIn: [cetinyazici](https://www.linkedin.com/in/cetinyazici)
- GitHub: [cetinyazici](https://github.com/cetinyazici)
