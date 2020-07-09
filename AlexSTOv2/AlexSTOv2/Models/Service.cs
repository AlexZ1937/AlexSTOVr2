using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public Category MyCategory { get; set; }
        public Master TMaster { get; set; }
        public Car MyCar { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Order MyOrder { get; set; }

        public Service()
        {
           
        }

        public Service(int ServiceId_, Category CategoryId_, Master MasterId_, Car CarId_, Order MyOrder_,decimal Price_, string Descript_)
        {
            this.ServiceId = ServiceId_;
            this.MyCategory = CategoryId_;
            this.TMaster = MasterId_;
            this.MyCar = CarId_;
            this.MyOrder = MyOrder_;
            this.Price = Price_;
            this.Description = Descript_;
        }
    }
}