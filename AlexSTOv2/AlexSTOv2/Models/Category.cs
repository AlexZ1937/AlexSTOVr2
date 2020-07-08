using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public Category(int CategoryID_, string Name_)
        {
            this.CategoryID = CategoryID_;
            this.Name = Name_;
        }
    }
}