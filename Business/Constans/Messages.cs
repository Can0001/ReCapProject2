using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {

        //Public messages
        public static string MaintenanceTime = "System Maintenance";

        //Car messages
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated  = "Araba Güncellendi";
        public static string CarListed = "Araba Listelendi";
        public static string CarDetailListed = "Detaylı Araba Listelendi";
        public static string CarDetailListedByBrandId = "Markaya Göre Araba Listelendi ";
        public static string CarDetailListedByColorId = "Renge Göre Araba Listelendi ";


        //Color messages
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renk Listelendi";

        //Brand messages
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandListed = "Marka Listelendi";

        //Customer messages
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteri Listelendi";

        //Rental messages
        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdated = "Kiralama Güncellendi";
        public static string RentalListed = "Kiralamalar Listelendi";
        public static string CarIsAlreadyRented = "Bu Araç Zaten Kiraya Verilmiş";

        //User messages
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcı Listelendi";

        public static string RentalListedByCarDetails = "Araç Detaylarına Göre Listelenen Kiralama";
        public static string RentalListedByNotRentedCars = "Kiralanmayan Araçlara Göre Listelenen Kiralama";
        public static string RentalListedByRentedCars = " Kiralık Araçlara Göre Listelenen Kiralama";
    }
}
