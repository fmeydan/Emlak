using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakMelegi.BusinessLogicLayer.KatmanliTanimi
{
    class Tanimlama
    {
        /*
         Bir Katmanlı mimari projesi nasıl oluşturulur
         1-Blank Solution ile boş bir proje oluşturulur(Other Project type )
         2-Boş Solution alanına BLL,DLL katmanları için Class Library, UI katmanı için Windows Form,Web katmanı için web seçenekleri seçilerek katmanlı mimari projesi  oluşturulmuş olunur
         */
        /*
         Katmanlı Mimariler
         => Katmanlı mimariler projeleri kategori yapılarına göre ayırıp, her bir kategori yapısına göre katman oluşturup kodları ilgili katmanına yazma teknolojisidir. Katmanlı Mimarileri katmanına göre aşağıdaki katmanlara göre bölebiliriz
         1-DLL
         2-BLL
         3-Entities
         4-UI=>Masaüstü
         5-UI=> Web
         6-UI=> Phone
         7-UI=>API
         8-Core        
         
         */
         /*
         1-Database Logic Layer(DLL)=>Veritabanı işlemlerinin yapıldığı katman
         2-Business Logic Layer(BLL)=>CRUD işlemlerinin yapıldığı katman. Bütün iş yükü bu katmandadır. Katmanlar arasında en yoğun kod yazılan katmandır. Ekleme, güncelleme, silme,listeleme, filtreleme, arama , vb kodları bu katmanda yazarız. Bu katman  için aşağıdaki işlemler yapılmalı
         => References alanına ilgili veritabanı katmanı(DLL) eklenmelidir
         => Using kütüphane ekleme alanına DLL katmanı eklenmelidir.
         Yukardaki yapıları eklemezsek veritabanı ile iletişim kuramayız, veriatabanı ile iletişim kurumlazsa hiç bir CRUD işlem yapılamaz
         CRUD=> Create, Read, Update,Delete
         3-User Interface(UI)=>Kullanıcıya gösterilecek arayüz katmanıdır.DLL,BLL katmanlarının amacı bu katmana veri alışverişinin sağlıklı bir şekilde  olmasını sağlamaktır.aşağıdaki işlemler yapılmalıdır
         => References alanına DLL,BLL katmanlarını eklemek
         => References alanına eklelenen BLL,DLL katmanlarını using kütüphane alanında çağırmaktır.
         4-Entities=>Code First gibi kendi veritabanı oluşturma, tablo oluşturma kodlarının yapıldığı katmandır.
         yukardaki işlemleri yaptıktan sonra 
         =>App.Config (DLL ve UI) sayfalarının connectionstring tag i içindeki SQl adreslerini DLL katmanındaki ile aynı olacak şekilde ayarlamamız gereklidir.
         =>Bütün katmanların Entity Framework kütüphanelerini aynı sürüm olacak şekilde ayarlamamız gereklidir.
         
         */

    }
}
