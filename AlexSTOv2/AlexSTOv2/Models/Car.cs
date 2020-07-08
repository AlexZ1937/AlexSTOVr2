using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public string CarColor { get; set; }

        public Car(int CarID_, string CarName_, string CarType_, string CarColor_)
        {
            this.CarID = CarID_;
            this.CarName = CarName_;
            this.CarType = CarType_;
            this.CarColor = CarColor_;
        }
    }
}