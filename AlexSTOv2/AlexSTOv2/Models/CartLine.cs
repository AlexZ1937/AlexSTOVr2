﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class CartLine
    {
        public int ID { get; set; }

        public virtual Cart Somecart {get; set;}
        public virtual Service buyservice { get; set; }
        public CartLine()
        {
            //пока не уверен пригодиться ли этот класс

        }
    }
}