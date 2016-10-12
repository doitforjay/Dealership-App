using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Models
{

    
    public class ViewModel
    {
       
        public IEnumerable <Dealer> dealers { get; set; }

        public IEnumerable <DealerInventory> Dlrinv { get; set; }
        public List<DealerInventory> inventory { get; set; }
        public IEnumerable<Color> Clrs { get; set; }
        public IEnumerable<Make> mks { get; set; }
        public IEnumerable<Model> mdls { get; set; }

        public virtual Color Color { get; set; }
        public virtual Dealer Dealer { get; set; }
        public virtual Model Model1 { get; set; }
        public virtual Make Make1 { get; set; }
        public Nullable<int> Year { get; set; }
        public string ColorDesc { get; set; }
        public Nullable<int> Miles { get; set; }
        public string pic { get; set; }
    

    }
      
        
}