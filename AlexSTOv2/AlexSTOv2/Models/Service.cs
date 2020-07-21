using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace AlexSTOv2.Models
{
    public class Service
    {
        
        public int ServiceId { get; set; }
        public virtual Category MyCategory { get; set; }
        public virtual Master TMaster { get; set; }
        public virtual Car MyCar { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual Order MyOrder { get; set; }

        public virtual Cart MyCart { get; set; }

        public Service()
        {
           
        }

        public Service(int ServiceId_, Category CategoryId_, Master MasterId_, Car CarId_, Order MyOrder_,decimal Price_, string Descript_, Cart Mycart)
        {
            this.ServiceId = ServiceId_;
            this.MyCategory = CategoryId_;
            this.TMaster = MasterId_;
            this.MyCar = CarId_;
            this.MyOrder = MyOrder_;
            this.Price = Price_;
            this.Description = Descript_;
            this.MyCart = Mycart;
        }
    }
}