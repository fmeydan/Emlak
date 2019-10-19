using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakMelegi.DatabaseLogicLayer;

namespace EmlakMelegi.BusinessLogicLayer.Manager
{
     public class PersonelManager
     {
        EmlakMelegiDBEntities1 db = new EmlakMelegiDBEntities1();

        #region Kaydetme
        public string PersonelSave(string tc, string ad, string soyad, bool cinsiyet, string telefon, string mail, string bolum, decimal maas, string adres)
        {
            try
            {
                int tcUzunluk = tc.Length;
                if (!string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad) && !string.IsNullOrWhiteSpace(bolum) && (cinsiyet != true || cinsiyet != false) && tcUzunluk == 11)
                {
                    //Entitiy frameworkd ile veritabanı işlemleri
                    // var varmiTc1 = db.Personeller.FirstOrDefault(k => k.PersonelTC == tc);
                    //varmiTc ile veritabanında eklenmek istenen tc ile aynı personel veritabanında var mı yok mu sorgusu yapacağız.
                    //   var varmiTc2 = db.Personeller.Where(k => k.PersonelTC == tc).FirstOrDefault();
                    //FirstOrDefault() metodu veritabanında eşleşen bir veri varsa o eşleşen ilk veriyi alır.
                    var varmiTc3 = db.Personeller.Any(s => s.PersonelTC == tc);
                    //Any() metodu geriye true yada false deger döndürür. boolean veri tipinde sonuç getirir.
                    //s=>s ----> lambda expression tanımlamasıdır. buradaki harf herhangi bir değişkendir, istenilen herhangi bir harf yada sözcük kullanıabili. harf artık bu sorguda personeller tablosu yerine kullanılacaktır.
                    if (varmiTc3 == false)
                    {
                        Personeller ekle = new Personeller();
                        ekle.PersonelTC = tc;
                        ekle.Adi = ad;
                        ekle.Soyadi = soyad;
                        ekle.Adresi = adres;
                        ekle.Bolumu = bolum;
                        ekle.Maas = maas;
                        ekle.MailAdresi = mail;
                        ekle.Telefonu = telefon;
                        ekle.Cinsiyeti = cinsiyet;
                        //Entity Framework ile nesneden alınan veriyi veritabanına kaydetme işlemi aşağıdaki gibi gerçekleştirilecektir.

                        db.Personeller.Add(ekle);
                        int sonuc = db.SaveChanges();
                        if (sonuc > 0)
                        {
                            return "adı: " + ad + " ve soyadı: " + soyad + " olan personel başarılı bir şekilde eklendi.";
                        }
                        else
                        {
                            return "Personel eklenirken hata oluştu";
                        }

                    }
                    return tc + " tc ye sahip personel mevcut";
                }
                return "Adı, Soyadı, Bölüm, Cinsiyet seçimi zorunludur";
            }
            catch (Exception)
            {

                return "hata";

            }


        }
        #endregion
        #region Listeleme
        public List<Personeller> PersonelList()
        {
            return db.Personeller.ToList();
        } 
        #endregion
        #region Global Field Değişkenleri
        public string gelenad, gelensoyad, gelentc, gelencinsiyet, gelentelefon, gelenmailadres, gelenbolum, gelenadres;
        public decimal gelenmaas;
        public int personel_ID;
        #endregion
        #region Tc ile Getir
        public bool TcilePersonelGetir(string tc)
        {
            var varsaTc = db.Personeller.Where(f => f.PersonelTC == tc).FirstOrDefault();
            if (varsaTc != null)
            {
                gelenad = varsaTc.Adi;
                gelensoyad = varsaTc.Soyadi;
                gelentc = varsaTc.PersonelTC;
                gelentelefon = varsaTc.Telefonu;
                gelenadres = varsaTc.Adresi;
                gelenmailadres = varsaTc.MailAdresi;
                gelenbolum = varsaTc.Bolumu;
                gelenmaas = (decimal)varsaTc.Maas;
                personel_ID = varsaTc.PersonellerID;
                try
                {
                    gelencinsiyet = varsaTc.Cinsiyeti.ToString();
                }
                catch (Exception)
                {

                    gelencinsiyet = null;
                }
                return true;
            }
            return false;
        }
        #endregion
        #region Güncelleme
        public string PersonelUpdate(int personel_ID,string tc, string ad, string soyad, bool cinsiyet, string telefon, string mail, string bolum, decimal maas, string adres)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ad)&& !string.IsNullOrWhiteSpace(soyad) && !string.IsNullOrWhiteSpace(bolum)&&(cinsiyet!=true || cinsiyet!=false) && tc.Length==11)
                {
                    var update = db.Personeller.Where(u => u.PersonellerID == personel_ID).FirstOrDefault();
                    if (update!=null)
                    {
                        update.Adi = ad;
                        update.Soyadi = soyad;
                        update.PersonelTC = tc;
                        update.Telefonu = telefon;
                        update.MailAdresi = mail;
                        update.Bolumu = bolum;
                        update.Adresi = adres;
                        update.Maas = maas;
                        update.Cinsiyeti = cinsiyet;
                        //EF ile güncelleme işlemi için aşağıdaki işlemi yapmak yeterli olur.
                        int sonuc = db.SaveChanges();
                        if (sonuc>0)
                        {
                            return ad + " isimli personel başarılı bir şekilde güncellendi";
                        }

                        return "Güncelleme esnasında bir hata meydana geldi";
                    }

                    return "Seçim yapılmalıdır";
                }

                return "Tc 11 haneli olmalı ve Adı,Soyadı,Cinsiyeti ve Bölümü boş bırakılamaz";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }
        #endregion
        #region Silme
        public string personelDelete (string tc)
        {
            try
            {
                if (tc.Length==11)
                {
                    var delete = db.Personeller.FirstOrDefault(k => k.PersonelTC == tc);
                    db.Personeller.Remove(delete);
                    int resultDel = db.SaveChanges();
                    if (resultDel>0)
                    {
                        tc = null;
                        return delete.Adi + " isimli personel başarılı bir şekilde silindi";
                    }
                    return "Silme işleminde hata oluştu";
                }
                return "Herhangi bir seçim yapmadınız";
            }
            catch (Exception)
            {

                return "İşlem sırasında bir hata meydana geldi";
            }


            
        }
        #endregion

        #region Fake Data 
        public void FakeDataPersoneller()
        {
            Personeller ekle = new Personeller();
            var sonuc = db.Personeller.Count();
            if (sonuc < 50)
            {
                for (int i = 0; i < 50; i++)
                {
                    Random rnd = new Random();
                    ekle.PersonelTC = (rnd.Next(100000000, 999999999) * 100).ToString();
                    ekle.Adi = FakeData.NameData.GetFirstName();
                    ekle.Soyadi = FakeData.NameData.GetSurname();
                    ekle.Telefonu = FakeData.PhoneNumberData.GetPhoneNumber();
                    ekle.Bolumu = "Yeni";
                    ekle.Maas = rnd.Next(2500, 10000);
                    db.Personeller.Add(ekle);
                    db.SaveChanges();
                }

            }
        }
        #endregion

    }
}
