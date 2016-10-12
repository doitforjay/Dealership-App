using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.DALs;
using WebApp.Models;


namespace WebApp.Controllers
{

    public class DealerController : Controller
    {

        // GET: Dealers
        public ActionResult Index()
        {
            DealerDAL dealer = new DealerDAL();
            ViewModel model = new ViewModel();
            model.dealers = dealer.getdealers();

            DealerInvDAL inv = new DealerInvDAL();
            model.Dlrinv = inv.getinv();

            return View(model);
        }
        //Filter Inventory table by dealer ID
        public PartialViewResult FilterTable(int ID)
        {
            DealershipTestDBEntities2 db = new DealershipTestDBEntities2();
            ViewModel mod = new ViewModel();
            mod.Dlrinv = db.DealerInventories.Where(c => c.DealerID == ID).OrderByDescending(c => c.DealerID).ToList();

            return PartialView("_Inventory", mod);
        }
        public ActionResult Create()
        {
            return View();
        }
        // POST: New dealer inventory
        [HttpPost]
        public ActionResult Create(DealerInventory di)
        {

            DealershipTestDBEntities2 db = new DealershipTestDBEntities2();

            db.DealerInventories.Add(di);
            db.SaveChanges();
            ViewBag.Message = "record added";
            return View();

        }
        // Display modal popup of inventory details
        public PartialViewResult modal()
        {
            
            ViewModel model = new ViewModel();

            DealerInvDAL inv = new DealerInvDAL();
            model.Dlrinv = inv.getinv();
            model.mks = inv.addMake();
            model.Clrs = inv.add();
            model.mdls = inv.addModel();
          
            return PartialView("_Details", model);
        }

    }



}
