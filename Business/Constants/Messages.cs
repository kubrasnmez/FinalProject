using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concreate;
using Entities.Concreate;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Categorydeki ürün sayısını aştınız.";
        public static string ProductNameAlreadyExists = "Bu ürün isminde bir ürün zaten var.";
        public static string CategoryListed = "Kategoriler listelendi";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı";
       public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
