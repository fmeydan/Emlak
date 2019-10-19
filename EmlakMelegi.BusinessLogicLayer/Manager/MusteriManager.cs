using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakMelegi.DatabaseLogicLayer;

namespace EmlakMelegi.BusinessLogicLayer.Manager
{
    public class MusteriManager
    {
        EmlakMelegiDBEntities1 db = new EmlakMelegiDBEntities1();
        

        List<Musteriler> MusteriList()
        {
            //Entity framework eklenmeden Musteriler tablosu burda kullanılamaz
            return db.Musteriler.ToList();

        }


       
    }
}
