using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi!";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz!";
        public static string MaintenanceTime = "Sistem Bakımda!";
        public static string ProductListed = "Ürünler Listelendi!";
        public static string ProductUpdated = "Ürün Güncellendi!";
        public static string ProductCountOfCategoryError = "Aynı Kategoride En Fazla 15 Ürün Olabilir!";
        public static string ProductNameAlreadyExists = "Aynı İsimde Başka Bir Ürün Eklenemez!";
        public static string CategoryLimitExcided = "Kategori Limiti Aşıldığı İçin Ürün Eklenemiyor!";
        public static string AuthorizationDenied = "Bu İşlem İçin Yetkiniz Yok!";
        public static string UserNotFound = "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Parola Hatalı!";
        public static string UserRegistered = "Üyelik Oluşturuldu!";
        public static string SuccessfulLogin = "Giriş Yapıldı!";
        public static string UserAlreadyExists = "Kullanıcı Mevcut!";
        public static string AccessTokenCreated = "Token Oluşturuldu!";
    }
}
