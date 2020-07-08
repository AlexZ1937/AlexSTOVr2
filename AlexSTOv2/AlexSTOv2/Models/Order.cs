using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Good MyGood { get; set; }

        public Order(int OrderId_, Good Good_Id_)
        {
            this.OrderId = OrderId_;
            this.MyGood = Good_Id_;
        }
    }
}