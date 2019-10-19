using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakMelegi.DatabaseLogicLayer;

namespace EmlakMelegi.BusinessLogicLayer.Manager
{
    interface IKategoriler
    {
        string KategoriKaydet(string kategoriAdi);
        string KategoriGuncelle(int kategorilerId, string kategoriAdi);
        string KategoriSil(int kategorilerId);
        List<Kategoriler> KategoriListe();
        void IDenemeMetot(string Deneme);
    }
}
