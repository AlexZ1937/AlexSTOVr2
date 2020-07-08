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

        public Good(int GoodID_, string Name_)
        {
            this.GoodID = GoodID_;
            this.Name = Name_;
        }
    }
}