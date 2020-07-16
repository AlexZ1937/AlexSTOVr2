using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual Good MyGood { get; set; }
        public decimal Price { get; set; }

        public Order()
        {
            
        }

        public Order(int OrderId_, Good Good_Id_,decimal Price_)
        {
            this.OrderId = OrderId_;
            this.MyGood = Good_Id_;
            this.Price = Price_;
        }
    }
}