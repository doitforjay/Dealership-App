using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;
using WebApp.DALs;
using WebApp.AppLevel;

namespace WebApp.DALs
{
    public class DealerDAL {
        private DealershipTestDBEntities2 db = new DealershipTestDBEntities2();
        AppLvl set = new AppLvl();
        public List <Dealer> getdealers(){
             List <Dealer> dealers = db.Dealers.ToList();
            db.Database.Connection.ConnectionString  = set.setConnectionString("DealershipTestDB");
             return dealers;
        }
        public Dealer getdealer(int id)
        {
            Dealer dlr = db.Dealers.Find(id);
            return dlr;
        }
   
    }
}