# Session Tracking App (Seans Takip uygulaması)

SessionTracking, sinema salonlarında oturum yönetimi ve müşteri bilgileri takibi için kullanılan bir Windows Forms uygulamasıdır. Bu uygulama, sinema salonlarının işletmecilerine, film gösterimleri için oturum yönetimi yapmalarını ve müşteri bilgilerini takip etmelerini sağlar. Oturumların ve müşteri bilgilerinin kolayca kaydedilmesi ve görüntülenmesi için kullanıcı dostu bir arayüze sahiptir.

----------------------
# Kurulum

* Projeyi indirin veya klonlayın.
* Visual Studio IDE'sinde projeyi açın.
* Gerekli paketlerin yüklenmesi için NuGet Package Manager'ı kullanın.
* Veritabanı dosyasını oluşturmak için Package Manager Console'da Update-Database komutunu çalıştırın.

----------------------
# Kullanım Kılavuzu

Film Ekleme 
* Uygulamayı başlatın ve "FILMS" sekmesine geçin.
* "FILM NAME" metin kutusuna eklemek istediğiniz film adını girin.
* Her bir gösterim için dört farklı saat belirleyin. Bunun için "Gösterim Saatleri" saat seçicilerini kullanın.
* "ADD" butonuna tıklayarak filmi kaydedin.

Salon Ekleme
* "LOUNGE" sekmesine geçin.
* "LOUNGE NAME" metin kutusuna eklemek istediğiniz salon adını girin.
* Salonun kapasitesini belirleyin. Bu alana yalnızca sayı girebilirsiniz.
* "ADD" butonuna tıklayarak salonu kaydedin.

Seans Oluşturma
* "SESSION" sekmesine geçin.
* Bir film seçmek için "FILM NAME" combobox'ından bir film seçin. (Daha önce kayıt ettiğiniz filmler burada gözükecektir.)
* Bir salon seçmek için "LOUNGE NAME" combobox'ından bir salon seçin. (Daha önce kayıt ettiğiniz salonlar burada gözükecektir.)
* Bir tarih seçmek için "FILM DATE" bölümündeki takvimden bir tarih seçin.(Daha önce kayıt ettiğiniz tarihler burada gözükecektir.)
* Bir saat seçmek için "FILM TIME" combobox'ından uygun gösterim saatini seçin. (Daha önce kayıt ettiğiniz film saatleri burada gözükecektir.)
* "ADD" butonuna tıklayarak seans oluşturun.

Müşteri Bilgileri Girişi
* "CUSTOMER PAGE" sekmesine geçin.
* Müşterinin adını ve soyadını "NAME" ve "SURNAME" metin kutularına girin.
* Müşterinin kredi kartı bilgilerini "BANK CARD" ve "CVC" metin kutularına girin. Kart numarası ve güvenlik kodu belirli bir formatı takip etmelidir.
* Kartın geçerlilik süresini ay ve yıl olacak şekilde "PERIOD OF VALIDITY" combobox'ından seçin.
* "ADD" butonuna tıklayarak müşteri bilgilerini kaydedin.

-------------
# Veritabanı Ve ORM Kullanımı

* SessionTracking uygulamasında veri depolama işlemleri için SQLite veritabanı kullanılmaktadır.
* Veritabanı işlemleri ve nesne ilişkilendirme (ORM) için Entity Framework Core kullanılmaktadır. Entity Framework Core, .NET platformu için güçlü bir ORM aracıdır ve veritabanı işlemlerini kolaylaştırır.

----------------------
# Geliştirici Notları

* Program.cs dosyasında bulunan pathDB sabiti ile SQLite veritabanı dosyasının konumu belirlenir.
* Kodlar içerisindeki metinsel açıklamalar (yorumlar) ile kod blokları açıklanmıştır. Detaylı bilgi almak için bu açıklamalara başvurabilirsiniz.

