using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;
using WebApp.AppLevel;

namespace WebApp.DALs
{
    public class DealerInvDAL
    {
        private DealershipTestDBEntities2 db = new DealershipTestDBEntities2();
        AppLvl set = new AppLvl();
        public DealerInventory getInventory()
        {
            DealerInventory dealerinv = db.DealerInventories.FirstOrDefault(); 

            return dealerinv;
        }
        public List <DealerInventory> getinv()
        {
            db.Database.Connection.ConnectionString = set.setConnectionString("DealershipTestDB");
            List <DealerInventory> dlrinv = db.DealerInventories.ToList();
            return dlrinv;
        }
        public List <Color> add()
        {
            List<Color> clr = db.Colors.ToList();
            return clr;
        }
        public List<Make> addMake()
        {
            List<Make> mk = db.Makes.ToList();
            return mk;
        }
        public List<Model> addModel()
        {
            List<Model> md = db.Models.ToList();
            return md;
        }
       
    }
}