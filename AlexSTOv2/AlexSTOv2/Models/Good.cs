using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Good
    {
        public int GoodID { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Good(int GoodID_, string Name_, decimal Price_)
        {
            this.GoodID = GoodID_;
            this.Name = Name_;
            this.Price = Price_;
        }
    }
}