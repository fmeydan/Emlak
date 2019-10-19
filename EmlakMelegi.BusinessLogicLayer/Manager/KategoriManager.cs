using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakMelegi.DatabaseLogicLayer;

namespace EmlakMelegi.BusinessLogicLayer.Manager
{
   public class KategoriManager : IKategoriler
    {
        public void IDenemeMetot(string Deneme)
        {
            throw new NotImplementedException();
        }
        EmlakMelegiDBEntities1 db = new EmlakMelegiDBEntities1();

        #region Güncelle
        public string KategoriGuncelle(int kategorilerId, string kategoriAdi)
        {
            try
            {
                if (kategorilerId != 0 && string.IsNullOrWhiteSpace(kategoriAdi))
                {
                    var update = db.Kategoriler.FirstOrDefault(f => f.KategorilerID == kategorilerId);
                    if (update != null)
                    {
                        update.KategoriAdi = kategoriAdi;
                        update.KategorilerID = kategorilerId;
                        return "Güncelleme başarılı.";
                    }
                    return "Böyle bir kategori mevcut değil";
                }
                return "Alanlar boş geçilemez";
            }
            catch (Exception)
            {

                return "Güncelleme başarısız";
            }

        } 
        #endregion  
        #region Kaydet
        public string KategoriKaydet(string kategoriAdi)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(kategoriAdi))
                {
                    var varmiKategori = db.Kategoriler.FirstOrDefault(h => h.KategoriAdi == kategoriAdi);
                    if (varmiKategori == null)
                    {
                        Kategoriler ekle = new Kategoriler();
                        ekle.KategoriAdi = kategoriAdi;

                        db.Kategoriler.Add(ekle);
                        if (db.SaveChanges() > 0)
                        {
                            return kategoriAdi + " olan kategori başarılı bir şekilde eklendi";
                        }
                        return "Eklenme hatası";
                    }
                    return varmiKategori.KategoriAdi + " adından kategori mevcut, kontrol ediniz";
                }

                return "Kategori adı boş geçilemez";

            }
            catch (Exception)
            {
                return "Hata";
            }
        }
        #endregion
        #region Listele
        public List<Kategoriler> KategoriListe()
        {
            return db.Kategoriler.ToList();
        } 
        #endregion
        #region Sil
        public string KategoriSil(int kategorilerId)
        {
            try
            {
                if (kategorilerId != 0)
                {
                    var delete = db.Kategoriler.FirstOrDefault(k => k.KategorilerID == kategorilerId);
                    if (delete != null)
                    {
                        db.Kategoriler.Remove(delete);
                        int resultdel = db.SaveChanges();
                        if (resultdel > 0)
                        {
                            return "Silme işlemi başarılı";
                        }
                        return "Silme işlemi başarısız";
                    }
                    return "Böyle bir kategori bulunamadı";
                }
                return "Bir seçim yapmadınız";
            }
            catch (Exception)
            {

                return "Bir hatayla karşılaşıldı";
            }
        } 
        #endregion
    }
}
