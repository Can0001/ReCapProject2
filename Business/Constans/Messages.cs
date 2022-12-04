using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed = "Arabalar Listelendi";
        public static string ColorListed = "Renkler Listelendi";
        public static string BrandListed = "Markalar Listelendi";
        public static string CarDeleted = "Araba Silindi";
        public static string ColorDeleted = "Renk Silindi";
        public static string BrandDeleted = "Marka Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string ColorUpdate = "Renk Güncellendi";
        public static string BrandUpdate = "Marka Güncellendi";
       
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdate = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";
      
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdate = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteri Listelendi";
        
        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdate = "Kiralama Güncellendi";
        public static string RentalListed = "Kiralamalar Listelendi";
        public static string RentalListedByCarDetails = "Araç Detaylarına Göre Listelenen Kiralama";
        public static string RentalListedByNotRentedCars = "Kiralanmayan Araçlara Göre Listelenen Kiralama";
        public static string RentalListedByRentedCars = " Kiralık Araçlara Göre Listelenen Kiralama";
        public static string CarIsAlreadyRented = "Bu Araç Zaten Kiraya Verilmiş";


        public static string AuthorizationDenied = "Yetkiniz Yok !!";
        public static string UserRegistered = "Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulanamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string EmailExist="E-Posta Var";

        public static string ImageError = "Resim Hatalı";
        public static string ImageDeleted = "Resim Silindi";
        public static string ImageNotFound = "Resim Bulunamadı";
        public static string ImageUpdated = "Resim Güncellendi";
        public static string ImageAdded = "Resim Eklendi";
        public static string ImageLimitHasBeenExceeded= "Görüntü Sınırı Aşıldı";
    }
}
